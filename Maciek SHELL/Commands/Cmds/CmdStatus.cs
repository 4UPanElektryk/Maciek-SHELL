using MShell.Commands.SubCmds;

namespace MShell.Commands.Cmds
{
    class CmdStatus : Cmd
    {
        public CmdStatus(string name) : base(name)
        {
            description = "Shows status of current machine";
            _Subs.Add(new CmdStatus_Live("live"));
            _Subs.Add(new CmdStatus_Default(null));
        }
    }
}
