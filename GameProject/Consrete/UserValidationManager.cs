using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1985 && gamer.FirstName == "engin" && gamer.LastName == "demirog" && gamer.IdentityNumber == 123456)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
