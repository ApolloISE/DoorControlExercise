using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

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
            DoorState = State.Closed;
        }

        public State DoorState
        {
            get;
            set;
        }

        public void RequestEntry(int id)
        {
            
            Console.WriteLine($"Entry requested for {id}");
            if (_userValidation.ValidateEntryRequest(id))
            {
                _door.Open();
                _entryNotification.NotifyEntryGranted(id);
                DoorState = State.Opening;
                Task.Delay(1000).ContinueWith(t=>DoorOpened());
               
            }
            else
            {
                _entryNotification.NotifyEntryDenied(id);
            }
            
        }

        public void DoorOpened()
        {
            if (DoorState != State.Opening)
            {
                DoorState = State.Breached;
                throw new AccessViolationException();
            }
            _door.Close();
            DoorState = State.Closing;
            Task.Delay(1000).ContinueWith(t => DoorClosed());
        }

        public void DoorClosed()
        {
            DoorState = State.Closed;
        }


    }

    public enum State
    {
        Opening,
        Closing,
        Closed,
        Breached
    };

}
