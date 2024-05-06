namespace Lista_Impl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContactList list = new ContactList();
            Contact c1 = new("Bernardo", "123");
            Contact c2 = new("Ana", "456");
            Contact c3 = new("Caue", "789");

            list.Add(c1);
            list.Add(c2);
            list.Add(c3);
            list.Add(new Contact("Bruna", "987"));

            list.RemoveFromName("caue");
        }
    }
}
