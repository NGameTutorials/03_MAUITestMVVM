using PropertyChanged;

namespace ATest1.Models
{
    [AddINotifyPropertyChangedInterface]
    public class ContactModel 
    {
        public ContactModel(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Guid Id { get; set; } = Guid.NewGuid();

    }
}
