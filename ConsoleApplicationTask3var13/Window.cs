using System;

namespace ConsoleApplicationTask3var13
{
    public class Window
    {
        private string name;
        private bool closed;

        public Window(string name)
        {
            this.name = name;
            this.closed = false;
        }

        public void open()
        {
            if (closed == false)
            {
                Console.WriteLine(name + ":" + "Окно уже открыто");
            }
            else
            {
                closed = false;
                Console.WriteLine(name + ":" + "Окно открыто");
            }
        }
        
        public void close()
        {
            if (closed == true)
            {
                Console.WriteLine("Окно уже закрыто");
            }
            else
            {
                closed = true;
                Console.WriteLine("Окно закрыто");
            }
        }

        public override string ToString()
        {
            string s;
            if (closed == true)
            {
                s = "закрыто";
            }
            else
            {
                s = "открыто";
            }

            return name + " " + s + ";";
        }
    }
}