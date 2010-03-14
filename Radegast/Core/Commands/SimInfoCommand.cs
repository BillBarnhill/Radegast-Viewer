﻿// 
// Radegast Metaverse Client
// Copyright (c) 2009, Radegast Development Team
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without
// modification, are permitted provided that the following conditions are met:
// 
//     * Redistributions of source code must retain the above copyright notice,
//       this list of conditions and the following disclaimer.
//     * Redistributions in binary form must reproduce the above copyright
//       notice, this list of conditions and the following disclaimer in the
//       documentation and/or other materials provided with the distribution.
//     * Neither the name of the application "Radegast", nor the names of its
//       contributors may be used to endorse or promote products derived from
//       this software without specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
// AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
// IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
// DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE
// FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
// DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
// SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
// CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
// OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
// OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
//
// $Id$
//
using System;
using System.Collections.Generic;
using System.Threading;
using System.Text;
using OpenMetaverse;

namespace Radegast.Commands
{
    public class SimInfoCommand : RadegastCommand
    {
        private RadegastInstance instance;

        public SimInfoCommand(RadegastInstance instance)
            : base(instance)
        {
            Name = "siminfo";
            Description = "Prints out available information about the current region";
            Usage = Name;

            this.instance = instance;
        }

        public override void Dispose()
        {
            base.Dispose();
        }

        public override void Execute(string name, string[] cmdArgs, ConsoleWriteLine WriteLine)
        {
            StringBuilder sb = new StringBuilder();
            Simulator sim = Client.Network.CurrentSim;
            
            sb.AppendLine();
            sb.AppendFormat("Information on region {0}:{1}", sim.Name, Environment.NewLine);
            sb.AppendFormat("Product name: {0}{1}", sim.ProductName, Environment.NewLine);
            sb.AppendFormat("Product SKU: {0}{1}", sim.ProductSku, Environment.NewLine);
            sb.AppendFormat("Regions per CPU: {0}{1}", sim.CPURatio, Environment.NewLine);
            sb.AppendFormat("CPU class: {0}{1}", sim.CPUClass, Environment.NewLine);
            sb.AppendFormat("Datacenter: {0}{1}", sim.ColoLocation, Environment.NewLine);
            sb.AppendFormat("Agents: {0}{1}", sim.Stats.Agents, Environment.NewLine);
            sb.AppendFormat("Active scripts: {0}{1}", sim.Stats.ActiveScripts, Environment.NewLine);
            sb.AppendFormat("Time dilation: {0}{1}", sim.Stats.Dilation, Environment.NewLine);
            
            WriteLine(sb.ToString());
        }
    }
}
