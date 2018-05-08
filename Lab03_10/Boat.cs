using System;
using System.Collections.Generic;
using System.Dynamic;

namespace Lab03_10
{
    public class Boat : Ship, ITransport, IMoored
    {
        private int PassangersCount = 0;

        public override string ToString()
        {
            return "Name: " + name + ". Type: " + type + ". Water deplacement: " + deplacement;
        }

        public Boat()
        {
            name = "";
            deplacement = 0.0d;
            type = "";
            categories = new List<RoomType>();
        }

        public Boat(string name, double deplacement, string type, List<RoomType> categories)
        {
            this.name = name;
            this.deplacement = deplacement;
            this.type = type;
            this.categories = categories;
        }

        public override void Move(double x, double y)
        {
            this.x = x;
            this.y = y;
            Console.WriteLine($"Moving to {x}, {y}");
        }

        public RoomType this[int index]
        {
            get { return categories[index]; }
            set { categories[index] = value; }
        }

        public void Load(int count)
        {
            if (PassangersCount < 0)
            {
                throw new NegativePassangerException();
            }

            PassangersCount += count;

        }

        public int Unload()
        {
            int passangerUnloaded = PassangersCount;
            PassangersCount = 0;
            return passangerUnloaded;
        }

        int IMoored.Unload()
        {
            return 0;
        }
    }
}
