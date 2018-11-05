namespace MenuShell1_2.Domain.Entities
{
    public class Owner
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long SocSecNr { get; set; }

        public Owner()
        {

        }

        public Owner(string firstName, string lastName, long socSecNr)
        {
            FirstName = firstName;
            LastName = lastName;
            SocSecNr = socSecNr;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName} {SocSecNr}";
        }
    }
}