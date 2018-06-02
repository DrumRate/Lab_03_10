using System;
using System.Collections.Generic;

namespace Lab03_10
{
    [Serializable]
    public class Ship
    {
        public override string ToString()
        {
            return "Name: " + name + ". Type: " + type + ". Water deplacement: " + deplacement;
        }

        public Ship()
        {
            name = "";
            deplacement = 0.0d;
            type = "";
            categories = new List<RoomType>();

        }

        public Ship(string name, double deplacement, string type, List<RoomType> categories)
        {
            this.name = name;
            this.deplacement = deplacement;
            this.type = type;
            this.categories = categories;
        }

        public virtual void Move(double x, double y)
        {
            this.x = x;
            this.y = y;
            Console.WriteLine($"Moving to {x}, {y}");
        }

        internal void Show()
        {
            throw new NotImplementedException();
        }

        internal void Activate()
        {
            throw new NotImplementedException();
        }

        protected string name;
        protected double deplacement;
        protected string type;
        protected List<RoomType> categories;
        protected double x;
        protected double y;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Deplacement
        {
            get { return deplacement; }
            set { deplacement = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public List<RoomType> Categories
        {
            get { return categories; }
            set { categories = value; }
        }

       // public MainForm MdiParent { get; internal set; }
        public string Text { get; internal set; }
        public int FormClosed { get; internal set; }
    }
}
