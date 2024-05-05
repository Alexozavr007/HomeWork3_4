using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_4_5
{
    internal class Content : BookPartBase
    {
        public Content(string content) : base(content)
        {
        }

        public override void Show()
        {
            var backUpColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Content);
            Console.ForegroundColor = backUpColor;
        }

        
    }
}
