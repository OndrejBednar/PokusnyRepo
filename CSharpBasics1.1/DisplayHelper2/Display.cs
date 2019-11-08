using System;

namespace DisplayHelper
{
    public class Display
    {
        private LabelItem _item;
        int _x, _y, _width, _height;

        public Display(int x = 0, int y = 0, int width = 80, int height = 5)
        {
            _x = x;
            _y = y;
            _width = width;
            _height = height;
        }

        public void AddItem(LabelItem item)
        {
            _item = item;
        }

        private void BClear()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(_x + 1, _y + 1);
            Console.WriteLine("╔══════════════════════╗");
            Console.SetCursorPosition(_x + 1, _y + 2);
            Console.WriteLine("║                      ║");
            Console.SetCursorPosition(_x + 1, _y + 3);
            Console.WriteLine("║                      ║");
            Console.SetCursorPosition(_x + 1, _y + 4);
            Console.WriteLine("╚══════════════════════╝");
        }
        private void B2Clear()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(_x + 1, _y + 1);
            Console.WriteLine("╔══════════════════════════════════════════╗");
            Console.SetCursorPosition(_x + 1, _y + 2);
            Console.WriteLine("║                                          ║");
            Console.SetCursorPosition(_x + 1, _y + 3);
            Console.WriteLine("║                                          ║");
            Console.SetCursorPosition(_x + 1, _y + 4);
            Console.WriteLine("║                                          ║");
            Console.SetCursorPosition(_x + 1, _y + 5);
            Console.WriteLine("║                                          ║");
            Console.SetCursorPosition(_x + 1, _y + 6);
            Console.WriteLine("║                                          ║");
            Console.SetCursorPosition(_x + 1, _y + 7);
            Console.WriteLine("╚══════════════════════════════════════════╝");
        }


        public void Refresh()
        {
            BClear();
            Console.SetCursorPosition(_x + 3, _y + 2);
            Console.WriteLine($"{_item.Name}: " + _item.Value);
            Console.SetCursorPosition(_x = 40,_y = 15);
            Console.BackgroundColor = ConsoleColor.Black;
            B2Clear();
            Console.SetCursorPosition(_x + 10, _y + 2);
        }
    }
}
