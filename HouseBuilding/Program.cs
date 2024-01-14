using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace HouseBuilding
{

    class Program
    {   
        static void Main(string[] args)
        {
            House house = new House();
            Team team = new Team();
            team.AddWorker(new Worker());
            team.AddWorker(new Worker());
            team.AddWorker(new Worker());
            team.AddWorker(new TeamLeader());

            team.BuildHouse(house);

            house.Show();
            Console.ReadKey();
        }
    }
}