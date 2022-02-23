using DoorControlExercise;

namespace FakeDoorControl
{
    public class FakeAlarm : IAlarm
    {
        public void RaiseAlarm()
        {
            Console.WriteLine("ALARM ALARM DOOR BREACHED");
        }
    }
}