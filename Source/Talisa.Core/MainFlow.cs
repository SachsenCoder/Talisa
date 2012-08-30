﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SachsenCoder.Talisa.Contracts;
using System.Diagnostics;

namespace SachsenCoder.Talisa.Core
{
    public class MainFlow
    {
        public MainFlow(IUserInterface ui)
        {
            _userInterface = ui;
            _createFlowToken = new Create_Flow_Token();

            _userInterface.RawFlowCode += _createFlowToken.Process;
        }

        private IUserInterface _userInterface;
        private Create_Flow_Token _createFlowToken;
    }
}
