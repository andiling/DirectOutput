﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DirectOutput.General.Generic
{
    public class NameChangeEventArgs:EventArgs
    {
        public string OldName { get; set; }
        public string NewName { get; set; }

        public NameChangeEventArgs() { }
        public NameChangeEventArgs(string OldName, string NewName)
        {
            this.OldName = OldName;
            this.NewName = NewName;
        }


    }
}