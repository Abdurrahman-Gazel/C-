using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("KAYIT OLDU");
            }
            else
            {
                Console.WriteLine("DOGRULAMA BASARISIZ. KAYIT BASARISIZ");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("KAYIT SILINDI");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("KAYIT GUNCELLENDI");
        }
    }
}
