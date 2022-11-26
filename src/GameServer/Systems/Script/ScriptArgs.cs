namespace Weedwacker.GameServer.Systems.Script
{
    internal class ScriptArgs
    {
        public int param1;
        public int param2;
        public int param3;
        public int source_eid; // Source entity
        public int target_eid;

        public ScriptArgs(int param1 = 0, int param2 = 0, int param3 = 0, int sourceEid = 0, int targetEid = 0)
        {
            this.param1 = param1;
            this.param2 = param2;
            this.param3 = param3;
            source_eid = sourceEid;
            target_eid = targetEid;
        }
    }
}