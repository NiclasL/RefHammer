namespace RefHammer.Model
{
    public class Round
    {
        public int Number { get; set; }
        public List<Pairing> Pairings { get; set; }

        public Round(int number)
        {
            Number = number;
            Pairings = new List<Pairing>();
        }

        public void AddPairing(Pairing pairing)
        {
            Pairings.Add(pairing);
        }
    }
}
