using System.Data;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Systems.Avatar;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Data
{
    internal static class DynamicFloatHelper
    {

        public static float ResolveDynamicFloat(object dynFloat, Avatar avatar, string configAbilityName)
        {
            if (dynFloat is double asFloat)
                return (float)asFloat;
            else if (dynFloat is string)
            {
                if (avatar.GetCurSkillDepot().AbilitySpecials[configAbilityName].ContainsKey(dynFloat as string))
                    return avatar.GetCurSkillDepot().AbilitySpecials[configAbilityName][dynFloat as string];
                else // eg %X+%Y
                    return ResolvePercentageSymbolReferences(dynFloat as string, avatar, configAbilityName);
            }
            else if (dynFloat is JArray expression)
            {
                return ResolvePolishNotation(expression.ToObject<string[]>(), avatar, configAbilityName);
            }
            else
            {
                Logger.WriteErrorLine($"Unknown dynamic float expression: {dynFloat}, {dynFloat.GetType()}");
                return 0;
            }
        }

        private static float ResolvePolishNotation(object[] expression, Avatar avatar, string configAbilityName)
        {
            Stack<float> myStack = new Stack<float>();
            float value;
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] is float asFloat)
                    myStack.Push(asFloat);
                else
                {
                    float local;
                    switch (expression[i] as string)
                    {
                        case "Add":
                            local = myStack.Pop() + myStack.Pop();
                            myStack.Push(local);
                            break;
                        case "Mul":
                            local = myStack.Pop() * myStack.Pop();
                            myStack.Push(local);
                            break;
                        default:
                            if (avatar.GetCurSkillDepot().AbilitySpecials[configAbilityName].TryGetValue(expression[i] as string, out float fVal))
                            {
                                myStack.Push(fVal);
                                break;
                            }
                            else if (float.TryParse(expression[i] as string, out float floatyFloat))
                            {
                                myStack.Push(floatyFloat);
                                break;
                            }
                            else if (avatar.FightProp != null && avatar.FightProp.TryGetValue((FightProperty)Enum.Parse(typeof(FightProperty), expression[i] as string), out float fightProp))
                            {
                                myStack.Push(fightProp);
                                break;
                            }
                            else
                            {
                                Logger.WriteErrorLine($"Unknown dynamic float expression: {expression}");
                                return 0;
                            }
                    }
                }
            }
            return myStack.Pop();
        }

        private static float ResolvePercentageSymbolReferences(string dynFloat, Avatar avatar, string configAbilityName)
        {
            var specials = Regex.Matches(dynFloat, @"(?<!\w)#\w+"); // match "%Word"
            foreach (Match match in specials)
            {
                string withoutPerc = Regex.Replace(match.Value, "%", "");
                if (avatar.GetCurSkillDepot().AbilitySpecials[configAbilityName].TryGetValue(withoutPerc, out float fVal))
                    dynFloat = Regex.Replace(dynFloat, match.Value, fVal.ToString());
                else if (avatar.FightProp.TryGetValue((FightProperty)Enum.Parse(typeof(FightProperty), match.Value), out float fightProp))
                    dynFloat = Regex.Replace(dynFloat, match.Value, fightProp.ToString());
                else
                {
                    Logger.WriteErrorLine("failed to dereference PercentageSymbolReference");
                    return 0;
                }
            }
            DataTable dt = new();
            return (float)dt.Compute(dynFloat, "");
        }
    }
}