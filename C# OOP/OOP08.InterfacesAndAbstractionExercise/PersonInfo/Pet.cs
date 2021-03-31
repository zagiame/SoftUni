namespace PersonInfo
{
    public class Pet : IPet
    {
        public Pet(string name, string birthdate)
        {
            this.name = name;
            Birthdate = birthdate;
        }

        public string name { get; }
        public string Birthdate { get; }
    }
}