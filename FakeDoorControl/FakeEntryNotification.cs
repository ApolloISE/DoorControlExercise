using DoorControlExercise;
using System.Linq;

namespace FakeDoorControl
{
    public class FakeEntryNotification : IEntryNotification
    {
        public KeyValuePair<string, int> Entry
        {
            get;
            set;
        }
        public void NotifyEntryDenied(int id)
        {
            Console.WriteLine($"Entry for {id} is denied");
            Entry = new KeyValuePair<string, int>("Denied", id);
        }

        public void NotifyEntryGranted(int id)
        {
            Console.WriteLine($"Entry for {id} granted");
            Entry = new KeyValuePair<string, int>("Granted", id);
        }

    }
}