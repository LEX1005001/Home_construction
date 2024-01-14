using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{

    public class Worker : IWorker
    {
        public void DoWork(List<IPart> parts)
        {
            foreach (var part in parts)
            {
                part.Build();
            }
        }
    }

    public class TeamLeader : IWorker
    {
        public void DoWork(List<IPart> parts)
        {
            Console.WriteLine("Отчет о построенных частях дома:");
            foreach (var part in parts)
            {
                part.Build();
            }
        }
    }

    public class Team
    {
        private List<IWorker> workers = new List<IWorker>();

        public void AddWorker(IWorker worker)
        {
            workers.Add(worker);
        }

        public void BuildHouse(House house)
        {
            List<IPart> parts = new List<IPart> 
            {
            new Basement(),
            new Wall(),
            new Wall(),
            new Wall(),
            new Wall(),
            new Door(),
            new Window(),
            new Window(),
            new Window(),
            new Window(),
            new Roof()
            };
           
           foreach (var worker in workers)
           {
              worker.DoWork(parts);
           }

            house.AddPart(parts[0]);
            house.AddPart(parts[1]);
            house.AddPart(parts[2]);
            house.AddPart(parts[3]);
            house.AddPart(parts[4]);
            house.AddPart(parts[5]);
            house.AddPart(parts[6]);
            house.AddPart(parts[7]);
            house.AddPart(parts[8]);
            house.AddPart(parts[9]);
            house.AddPart(parts[10]);
        }
    }
}
