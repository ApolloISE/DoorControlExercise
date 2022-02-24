using DoorControlExercise;

namespace FakeDoorControl
{
    public class FakeAlarm : IAlarm
    {
        public bool AlarmIsOn
        {
            get;
            private set;
        } = false;

        public void RaiseAlarm()
        {
            Console.WriteLine("ALARM ALARM DOOR BREACHED");
            AlarmIsOn = true;
        }
    }
}