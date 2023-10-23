using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пр_5__
{
    internal class SR_menu
    {
        public int maxstrel;
        public int minstrel;


        public int sr_menu()
        {
            int pos = 3;
            ConsoleKeyInfo key;

            key = Console.ReadKey();
            while (key.Key != ConsoleKey.Enter)
            {
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("  ");
                if (key.Key == ConsoleKey.UpArrow && pos != minstrel)
                {
                    pos--;
                }
                else if (key.Key == ConsoleKey.DownArrow && pos != maxstrel)
                {
                    pos++;
                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    return -1;
                }

                Console.SetCursorPosition(0, pos);
                Console.WriteLine("=>");
                key = Console.ReadKey();
            }

            return pos;


        }
    }
}
