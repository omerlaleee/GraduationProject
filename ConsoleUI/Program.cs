using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Runtime.Intrinsics.Arm;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Deprem Yardım Platformuna Hoşgeldiniz!");
            Console.WriteLine("Aşağıdaki seçenekleri sıra numaralarından giriş yaparak seçebilirsiniz.");
            Console.WriteLine("1. Depremzede Girişi");
            Console.WriteLine("2. Yardım Girişi");
            Console.WriteLine("3. Hasarlı Bina Girişi");
            Console.WriteLine("4. Listeleri Göster");
            Console.WriteLine();
            Console.Write("Seçiminiz : ");
            Console.Read();

            BuildReporterManager buildReporterManager = new BuildReporterManager(new EfBuildReporterDal());
            Console.WriteLine("Hasarlı Bina Bildirimi : ");
            BuildReporter buildReporter = new BuildReporter();
            Console.Write("Adı : ");
            buildReporter.Name = Console.ReadLine();
            Console.Write("Soyadı : ");
            buildReporter.Surname = Console.ReadLine();
            Console.Write("Email : ");
            buildReporter.Email = Console.ReadLine();
            Console.Write("Telefon Numarası : ");
            buildReporter.PhoneNumber = Console.ReadLine();
            Console.Write("Adres : ");
            buildReporter.Address = Console.ReadLine();
            Console.Write("Adres Detayı : ");
            buildReporter.DetailedAddress = Console.ReadLine();
            Console.Write("Aciliyet : ");
            buildReporter.Urgency = Console.ReadLine();
            Console.Write("Maps Adresi : ");
            buildReporter.MapsAddress = Console.ReadLine();
            Console.WriteLine();
            var result1 = buildReporterManager.Add(buildReporter);
            Console.WriteLine("Response : ");
            Console.WriteLine(result1.Success);
            Console.WriteLine("Building Report Was Added!");

            VictimManager victimManager = new VictimManager(new EfVictimDal());
            Console.WriteLine("Isınmaya İhtiyacı Olan Depremzede Ekleme: ");
            Victim victim1 = new Victim();
            Console.Write("Adı : ");
            victim1.Name = Console.ReadLine();
            Console.Write("Soyadı : ");
            victim1.Surname = Console.ReadLine();
            Console.Write("Email : ");
            victim1.Email = Console.ReadLine();
            Console.Write("Telefon Numarası : ");
            victim1.PhoneNumber = Console.ReadLine();
            Console.Write("Kişi Sayısı : ");
            victim1.NumberOfPeople = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adres : ");
            victim1.Address = Console.ReadLine();
            Console.Write("Adres Detayı : ");
            victim1.DetailedAddress = Console.ReadLine();
            Console.Write("Aciliyet : ");
            victim1.Urgency = Console.ReadLine();
            Console.Write("Durum Bilgisi : ");
            victim1.StatusInformation = Console.ReadLine();
            Console.Write("Maps Adresi : ");
            victim1.MapsAddress = Console.ReadLine();
            victim1.VictimType = "Isınma";
            var result2 = victimManager.Add(victim1);
            Console.WriteLine();
            Console.WriteLine("Response : ");
            Console.WriteLine(result2.Success);
            Console.WriteLine(result2.Message);

            //DebrisVictimManager debrisVictimManager = new DebrisVictimManager(new EfDebrisVictimDal());
            //DebrisVictim debrisVictim = new DebrisVictim();
            //debrisVictim.VictimId = x.Data.Id;
            //debrisVictimManager.Add(debrisVictim);
            //var result2 = debrisVictimManager.Add(new DebrisVictim { VictimId = 2 });
        }
    }
}
