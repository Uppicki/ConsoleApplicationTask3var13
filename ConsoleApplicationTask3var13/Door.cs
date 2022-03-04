using System;

namespace ConsoleApplicationTask3var13
{
    public class Door
    {
        private string name;
        private bool closed;
        private bool closedWithKey;

        public Door(string name)
        {
            this.name = name;
            this.closed = false;
            this.closedWithKey = false;
        }

        public void openWithKey()
        {
            if (closedWithKey == false)
            {
                Console.WriteLine(name + ":" + "Дверь уже открыта с помощью ключа");
            }
            else
            {
                closedWithKey = false;
                Console.WriteLine(name + ":" + "Дверь открыта с помощью ключа");
            }
            
            
        }

        public void closeWithKey()
        {
            if (closed == true)
            {
                closedWithKey = true;
                Console.WriteLine(name + ":" + "Дверь закрыта с помощью ключа");
            }
            else
            {
                Console.WriteLine(name + ":" + "Необходимо закрыть дверь");
            }
            
        }

        public void open()
        {
            if (closedWithKey == true)
            {
                Console.WriteLine(name + ":" + "Нужен ключ");
            }
            else
            {
                closed = false;
                Console.WriteLine(name + ":" + "дверь открыта");
            }
        }
        
        public void close()
        {
            closed = true;
            Console.WriteLine(name + ":" + "дверь закрыта");
        }
        
        public override string ToString()
        {
            string s;
            if (closed == true)
            {
                if (closedWithKey == true)
                {
                    s = "закрыта на ключ";
                }
                else
                {
                    s = "закрыта";
                }
            }
            else
            {
                s = "открыта";
            }

            return name + " " + s + ";";
        }
    }
}