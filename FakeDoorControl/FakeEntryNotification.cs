using DoorControlExercise;

namespace FakeDoorControl
{
    public class FakeEntryNotification : IEntryNotification
    {
        public void NotifyEntryDenied(int id)
        {
            Console.WriteLine($"Entry for {id} is denied");
        }

        public void NotifyEntryGranted(int id)
        {
            Console.WriteLine($"Entry for {id} granted");
        }
    }
}