namespace escapeRoom.Entities
{
    public class Coustomers_class
    {
        public int Id { get; set; }
        public string LName { get; set; }
        public string FName { get; set; }



        public Coustomers_class(int id, string lName, string fName)
        {
            Id = id;
            LName = lName;
            FName = fName;
        }
    }
}
