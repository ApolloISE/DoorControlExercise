using DoorControlExercise;

namespace FakeDoorControl
{
    public class FakeUserValidation: IUserValidation
    {
        public bool ValidateEntryRequest(int id)
        {
            Console.WriteLine($"ID {id} is okay, entry is alright");
            return true;
        }
    }
}