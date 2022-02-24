using System.Collections.Generic;
using DoorControlExercise;
using FakeDoorControl;
using NUnit.Framework;

namespace TestDoorControl
{

    public class Tests
    {
        FakeAlarm? _alarm;
        FakeDoor? _door;
        FakeEntryNotification? _entryNotification;
        FakeUserValidation? _userValidation;

        private DoorControl uut;
        [SetUp]
        public void Setup()
        {
            _alarm = new FakeAlarm();
            _door = new FakeDoor();
            _entryNotification = new FakeEntryNotification();
            _userValidation = new FakeUserValidation();
            uut = new DoorControl(_alarm, _door, _entryNotification, _userValidation);

        }
        
        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [TestCase("Denied",10)]
        [TestCase("Granted", 17)]
        public void RequestEntry_Is_Granted_Or_Denied(string entry, int id)
        {
            _userValidation.ValidateEntryAnswer = (entry=="Granted" ? true: false);
            uut.RequestEntry(id);
            Assert.That(_entryNotification.Entry,Is.EqualTo(new KeyValuePair<string,int>(entry,id)));

        }

    }
}