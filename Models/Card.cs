namespace PTCGP.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string CardName { get; set; }
        public string DisplayName { get; set; }
        public bool IsOwned { get; set; } = false;
    }
}
