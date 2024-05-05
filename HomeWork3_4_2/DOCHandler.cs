using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_4_2
{
    internal class DOCHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("Chenge inside DOC");
        }

        public override void Create()
        {
            Console.WriteLine("Create DOC");

        }

        public override void Open()
        {
            Console.WriteLine("Open DOC");
        }

        public override void Save()
        {
            Console.WriteLine("Save DOC");
        }

    }
    
 }

