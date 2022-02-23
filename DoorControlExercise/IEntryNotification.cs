using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControlExercise
{
    public interface IEntryNotification
    {
        public void NotifyEntryDenied(int id);
        public void NotifyEntryGranted(int id);

    }
}
