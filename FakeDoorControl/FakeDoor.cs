using DoorControlExercise;

namespace FakeDoorControl
{
    public class FakeDoor :IDoor
    {
        public void Open()
        {
            Console.WriteLine("Door is opening");
        }

        public void Close()
        {
            Console.WriteLine("Door is closing");
        }
    }
}