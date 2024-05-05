using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_4_5
{
    internal class Author : BookPartBase
    {

        public Author(string value): base(value) { }

        public override void Show()
        {
            var backUpColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Content);
            Console.ForegroundColor = backUpColor;
        }
    }
}
