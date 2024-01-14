using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class House
    {
        private List<IPart> parts = new List<IPart>();

        public void AddPart(IPart part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("Дом построен:");
            foreach (var part in parts)
            {
                part.Build();

            }
            Console.WriteLine("Рисунок дома:");
            Console.WriteLine("   /\\ ||");
            Console.WriteLine("  /  \\||");
            Console.WriteLine(" /____\\|");
            Console.WriteLine("|  0   |");
            Console.WriteLine("|______|");
        }
    }
    public class Basement : IPart
    {
        public void Build()
        {
            Console.WriteLine("Фундамент построен");
        }
    }
    public class Wall : IPart
    {
        public void Build()
        {
            Console.WriteLine("Стена построена");
        }
    }
    public class Door : IPart
    {
        public void Build()
        {
            Console.WriteLine("Дверь построена");
        }
    }
    public class Window : IPart
    {
        public void Build()
        {
            Console.WriteLine("Окно построено");
        }
    }
    public class Roof : IPart
    {
        public void Build()
        {
            Console.WriteLine("Крыша построена");
        }
    }

}
