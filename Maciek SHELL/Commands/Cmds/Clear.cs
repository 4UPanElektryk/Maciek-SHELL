﻿using MOS_User_Menager_Integration;
using Maciek_SHELL.Essentials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maciek_SHELL.Commands.Cmds
{
    class Clear : Cmd
    {
        public Clear(string name) : base(name) { }
        public override bool Execute(string[] args, string input, User user)
        {
            Console.Clear();
            Dual.Watermark();
            return true;
        }
    }
}
