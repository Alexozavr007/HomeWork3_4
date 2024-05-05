using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_4_5
{
    public abstract class BookPartBase
    {
        public string Content { get; set; }
        public abstract void Show();

        public BookPartBase (string content)
        {
            Content = content;
        }
    }
}
