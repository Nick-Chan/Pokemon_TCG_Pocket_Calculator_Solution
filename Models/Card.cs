namespace PTCGP.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string CardName { get; set; } // The descriptive name of the card
        public string DisplayName { get; set; } // The formatted name like "A1 001"
        public bool IsOwned { get; set; } = false; // Whether the card is owned
    }
}
