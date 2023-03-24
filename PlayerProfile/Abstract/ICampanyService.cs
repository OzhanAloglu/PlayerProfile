using PlayerProfile.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerProfile.Abstract
{
    public interface ICampanyService
    {

        void Add(Campany campany);

        void Delete(Campany campany);

        void Update(Campany campany);

    }
}
