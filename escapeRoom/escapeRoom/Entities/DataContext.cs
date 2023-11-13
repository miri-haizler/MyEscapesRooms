namespace escapeRoom.Entities
{
    public class DataContext
    {
        public List<Room_class> roomsList { get; set; }

        public List<Coustomers_class> customersList { get; set; }

        public List<Cards_Class> cardsList { get; set; }

        public DataContext()
        {
            roomsList = new List<Room_class>();
            roomsList.Add(new Room_class(10, "Kind Shlomo", true));
            roomsList.Add(new Room_class(20, "Prag room", false));
            roomsList.Add(new Room_class(30, "Zofen", true));
            roomsList.Add(new Room_class(40, "Hayara", true));

            customersList = new List<Coustomers_class>();
            customersList.Add(new Coustomers_class(123, "Brachi", "Dinkel"));
            customersList.Add(new Coustomers_class(456, "Miri", "Haizler"));
            customersList.Add(new Coustomers_class(789, "Sara", "Cohen"));
            customersList.Add(new Coustomers_class(258, "Lea", "Levi"));

            cardsList = new List<Cards_Class>();
        }

    }
}
