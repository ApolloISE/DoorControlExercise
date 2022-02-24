using DoorControlExercise;

namespace FakeDoorControl
{
    public class FakeAlarm : IAlarm
    {
        private bool alarmIsOn = false;
        public bool AlarmIsOn
        {
            get;
            private set;
        }

        public void RaiseAlarm()
        {
            Console.WriteLine("ALARM ALARM DOOR BREACHED");
            AlarmIsOn = true;
        }
    }
}