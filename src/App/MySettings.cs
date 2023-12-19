using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class MySettings
    {
        private readonly string[] _args;

        public MySettings(string[] args)
        {
            _args = args;
        }

        public Type BImpl { get { return GetBImpl(); } }

        private Type GetBImpl()
        {
            if (_args.Length == 1)
            {
                if (_args[0] == "2")
                    return typeof(LibraryB.Implementation2.B);
            }
            return typeof(LibraryB.Implementation1.B);
        }
    }
}
