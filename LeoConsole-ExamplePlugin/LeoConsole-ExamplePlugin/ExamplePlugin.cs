using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ILeoConsole;
using ILeoConsole.Plugin;
using ILeoConsole.Core;

namespace LeoConsole_ExamplePlugin
{
    public class ExamplePlugin : IPlugin
    {
        public string Name { get { return "ExamplePlugin"; } }

        public string Explanation { get { return "Example Plugin"; } }

        private IData _data;
        public IData data { get { return _data; } set { _data = value; } }

        private List<ICommand> _Commands;
        public List<ICommand> Commands { get { return _Commands; } set { _Commands = value; } }

        public void PluginMain()
        {
            // Add Data

            _data = new ConsoleData();


            // Add Commands

            _Commands = new List<ICommand>();
            _Commands.Add(new randomNumber());
        }
    }
}
