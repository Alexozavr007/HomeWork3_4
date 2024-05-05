using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_4_2
{
    internal class TXTHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("Chenge inside TXT");
        }

        public override void Create()
        {
            Console.WriteLine("Create TXT");

        }

        public override void Open()
        {
            Console.WriteLine("Open TXT");
        }

        public override void Save()
        {
            Console.WriteLine("Save TXT");
        }
    
    }
}
