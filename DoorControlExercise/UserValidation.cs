using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControlExercise
{
    public class UserValidation: IUserValidation
    {
        public bool ValidateEntryRequest(int id)
        {
            //Do real validation
            return true;
        }
    }
}
