using ATest1.Collections;

namespace ATest1.Models
{
    public static class ContactListGenerator
    {
        public static IEnumerable<ContactModel> GetContacts(int count)
        {
            var rand = new Random();
            var NamesMax = FirstNameList.Names.Length;
            var LastsMax = LastNameList.Lasts.Length;
            for (int i = 0; i < count; i++)
            {
                yield return new ContactModel(
                    FirstNameList.Names.ElementAt(rand.Next(0, NamesMax)),
                    LastNameList.Lasts.ElementAt(rand.Next(0, LastsMax)));
            }
        }
    }
}
