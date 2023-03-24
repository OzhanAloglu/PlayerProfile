using PlayerProfile.Abstract;
using PlayerProfile.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerProfile.Concrete
{
    public  class PlayerManager : IPlayerService
    {
       IPersonCheckService _personCheckService;

        public PlayerManager()
        {
        }

        public PlayerManager(IPersonCheckService personCheckService)
        {
            _personCheckService = personCheckService;
        }

        public  void Add(Player player)
        {
            if (_personCheckService.CheckIfRealPerson(player))
            {
                Console.WriteLine("Oyuncu eklendi." + player.FirstName);

            }

            else
            {
                Console.WriteLine("Geçerli bir kişi değil.");
            }


            
        }

        public void Delete(Player player)
        {
            Console.WriteLine("Oyuncu silindi."+player.FirstName);
        }

        public void Update(Player player)
        {
            Console.WriteLine("Oyuncu güncellendi." + player.FirstName);
        }

       
    }
}
