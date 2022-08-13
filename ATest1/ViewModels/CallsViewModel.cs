using ATest1.Models;
using PropertyChanged;
using System.Collections.ObjectModel;

namespace ATest1.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class CallsViewModel
    {

        public ObservableCollection<ContactModel> Contacts { get; } = new();

        public CallsViewModel()
        {
            new Thread(GenerateContacts).Start();
        }

        void GenerateContacts()
        {
            var list = ContactListGenerator.GetContacts(40);
            for (int i = 0; i < list.Count(); i++)
            {
                Contacts.Add(list.ElementAtOrDefault(i));

            }
        }
    }
}
