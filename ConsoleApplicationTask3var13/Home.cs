using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplicationTask3var13
{
    public class Home
    {
        private List<Door> doors = new List<Door>();
        private List<Window> windows = new List<Window>();

        public Home(int d, int w)
        {
            doors = new List<Door>();
            windows = new List<Window>();

            for (int i = 0; i < d; i++)
            {
                doors.Add(new Door($"door {i+1}"));
            }
            for (int i = 0; i < w; i++)
            {
                windows.Add(new Window($"window {i+1}"));
            }
        }
        
        public override string ToString()
        {
            string s = "Состояние дома:\n";

            s += "Двери:\n";
            foreach (Door d in doors)
            {
                s += "\t" + d + "\n";
            }

            s += "Окна:\n";
            foreach (Window w in windows)
            {
                s += "\t" + w + "\n";
            }

            return s;
        }

        public int doorsQ()
        {
            return (int) doors.Count;
        }
        
        public int windowsQ()
        {
            return (int) windows.Count;
        }

        public void openWindow(int index)
        {
            windows[index-1].open();
        }

        public void closeWindow(int index)
        {
            windows[index-1].close();
        }

        public void openDoor(int index)
        {
            doors[index-1].open();
        }

        public void closeDoor(int index)
        {
            doors[index-1].close();
        }

        public void openDoorWithKey(int index)
        {
            doors[index-1].openWithKey();
        }

        public void closeDoorWithKey(int index)
        {
            doors[index-1].closeWithKey();
        }
    }
}
