using DoorControlExercise;

namespace FakeDoorControl
{
    public class FakeDoor :IDoor
    {
        private bool isDoorOpen = false;
        public bool IsDoorOpen
        {
            get
            {
                return isDoorOpen;
            }
            set
            {
                isDoorOpen = value;
            }
        }

        public void Open()
        {
            Console.WriteLine("Door is opening");
            isDoorOpen = true;
        }

        public void Close()
        {
            Console.WriteLine("Door is closing");
            isDoorOpen = false;
        }
    }
}