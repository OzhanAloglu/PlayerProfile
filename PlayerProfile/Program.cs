using PlayerProfile.Adapters;
using PlayerProfile.Concrete;
using PlayerProfile.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerProfile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayerManager playerManager = new PlayerManager(new MernisServiceAdapter());
           

            playerManager.Add(new Player

            {
                DateOfBirth=new DateTime(1998,01,11),
                FirstName="Özhan",
                Lastname="Aloğlu",
                NationalityId="12332323"}
            );

            Console.ReadLine();


        }


    }
}
