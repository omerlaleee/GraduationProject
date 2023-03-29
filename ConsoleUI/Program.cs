using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VictimManager victimManager = new VictimManager(new EfVictimDal());
            var result1 = victimManager.Add(new Victim { Name = "A", Surname = "A", Email = "A", PhoneNumber = "0", NumberOfPeople = 1, Address = "A", DetailedAddress = "A", Urgency = "A", StatusInformation = "A", MapsAddress = "A" });
            Console.WriteLine(result1.Success);
            Console.WriteLine(result1.Message);

            //DebrisVictimManager debrisVictimManager = new DebrisVictimManager(new EfDebrisVictimDal());
            //var result2 = debrisVictimManager.Add(new DebrisVictim { VictimId = 2 });
        }
    }
}
