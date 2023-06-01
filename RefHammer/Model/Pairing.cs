namespace RefHammer.Model
{
    public class Pairing
    {
        public Participant Player1 { get; set; }
        public Participant Player2 { get; set; }

        public Pairing(Participant player1, Participant player2)
        {
            Player1 = player1;
            Player2 = player2;
        }
    }
}
