using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControlExercise
{
    public class EntryNotification: IEntryNotification
    {
        public void NotifyEntryDenied(int id)
        {
            //Notify denied real
        }

        public void NotifyEntryGranted(int id)
        {
            //Notofy granted real
        }
    }
}
