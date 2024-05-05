using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_4_3
{
    internal class Player : IPlayable, IRecodable
    {
        private bool isPlayActive = false;
        private bool isRecordActive = false;

        public void Play()
        {
            isPlayActive = true;
            Console.WriteLine("Відтворення");
        }

        public void Record()
        {
            isRecordActive = true;
            Console.WriteLine("Запис");
        }

        public void Pause()
        {
           if (isPlayActive)
            {
                Console.WriteLine("Паузимо відтворення");
            }
           else if (isRecordActive)
            {
                Console.WriteLine("Паузимо запис");
            }
           else
            {
                //Unexpected
            }
        }

        public void Stop()
        {
            if (isPlayActive)
            {
                Console.WriteLine("Зупиняєм відтворення");
                isPlayActive= false;
            }
            else if (isRecordActive)
            {
                Console.WriteLine("Зупиняєм запис");
                isRecordActive= false;
            }
            else
            {
                //Unexpected
            }
        }
    }
}
