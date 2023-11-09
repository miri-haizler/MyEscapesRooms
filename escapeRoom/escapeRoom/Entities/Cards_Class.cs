namespace escapeRoom.Entities
{
    public class Cards_Class
    {
        public int IdCard { get; set; }

        public int CountOfCard { get; set; }

        public int CIdRoom { get; set; }
        public Cards_Class(int idcard, int countofcard, int cidroom)
        {
            IdCard = idcard;
            CountOfCard = countofcard;
            CIdRoom = cidroom;
        }

    }
}
