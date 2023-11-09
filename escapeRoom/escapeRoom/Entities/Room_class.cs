namespace escapeRoom.Entities
{
    public class Room_class
    {
        public int Id { get; set; }
        public string Room_name { get; set; }
        public bool IsOpen { get; set; }

        int count;

        public Room_class(int id, string room_name, bool status)
        {
            Id = id;
            Room_name = room_name;
            IsOpen = status;
        }
        public int IsFull(int num)
        {
            return count += num;
        }
    }
}
