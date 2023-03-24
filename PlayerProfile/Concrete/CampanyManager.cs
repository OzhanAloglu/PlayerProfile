using PlayerProfile.Abstract;
using PlayerProfile.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerProfile.Concrete
{
    public class CampanyManager : ICampanyService
    {
        public void Add(Campany campany)
        {
            Console.WriteLine("Kampanya eklendi."+campany.Name);
        }

        public void Delete(Campany campany)
        {
            Console.WriteLine("Kampanya silindi."+campany.Name);
        }

        public void Update(Campany campany)
        {
            Console.WriteLine("Kampanya güncellendi." + campany.Name);
        }
    }
}
