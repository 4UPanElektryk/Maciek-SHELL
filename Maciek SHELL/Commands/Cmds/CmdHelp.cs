﻿using MShell.Integrations.User_Manager;
using System;

namespace MShell.Commands.Cmds
{
	class CmdHelp : Cmd
	{
		public CmdHelp(string name) : base(name)
		{
			description = "Wyświetla listę wszystkich komend";
			args = "<Command Name>";
		}

		public override bool Execute(string[] args, string input, User user)
		{
			Console.WriteLine("Command List:");
			foreach (Cmd cmd in CommandMenager.CmdList)
			{
				Console.WriteLine(cmd._Name + " - " + cmd.description);
			}
			return true;
		}
	}
}
