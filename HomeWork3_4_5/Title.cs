using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_4_5
{
    internal class Title : BookPartBase
    {

        public Title(string value):base(value) { 
        }

        public override void Show()
        {
            var backUpColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Content);
            Console.ForegroundColor = backUpColor;
        }
    }
}
