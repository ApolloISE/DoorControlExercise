using DoorControlExercise;
using FakeDoorControl;
using NUnit.Framework;

namespace TestDoorControl
{

    public class Tests
    {
        IAlarm? _alarm;
        IDoor? _door;
        IEntryNotification? _entryNotification;
        IUserValidation? _userValidation;
        private DoorControl uut;
        [SetUp]
        public void Setup()
        {
            _alarm = new FakeAlarm();
            _door = new FakeDoor();
            _entryNotification = new FakeEntryNotification();
            _userValidation = new UserValidation();
            uut = new DoorControl(_alarm, _door, _entryNotification, _userValidation);
        }
        
        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

    }
}