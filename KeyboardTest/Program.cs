using System;
using Gtk;

namespace KeyboardTest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Application.Init();
            MainWindow win = new MainWindow();
            win.KeyPressEvent += (o, e) => {
                Console.WriteLine($"Key {e.Event.KeyValue}, HW {e.Event.HardwareKeycode}");
            };
            win.Show();
            Application.Run();
        }
    }
}
