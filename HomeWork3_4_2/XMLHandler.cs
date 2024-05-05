using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_4_2
{
    internal class XMLHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("Chenge inside XML");
        }

        public override void Create()
        {
            Console.WriteLine("Create XML");

        }

        public override void Open()
        {
            Console.WriteLine("Open XML");
        }

        public override void Save()
        {
            Console.WriteLine("Save XML");
        }
    }
}
