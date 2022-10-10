using Weedwacker.GameServer.Systems.World;

namespace Weedwacker.GameServer.Systems.Script
{
    internal interface IScriptMonsterListener
    {
        void OnNotify(MonsterEntity sceneMonster);
    }
}
