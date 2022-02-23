using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControlExercise
{
    public class DoorControl
    {
        private IAlarm? _alarm;
        private IDoor? _door;
        private IEntryNotification? _entryNotification;
        private IUserValidation? _userValidation;

        public DoorControl(IAlarm alarm, IDoor door, IEntryNotification entryNotification, IUserValidation userValidation)
        {
            _alarm = alarm;
            _door = door;
            _entryNotification = entryNotification;
            _userValidation = userValidation;
        }




    }

    public enum State
    {

    }

}
