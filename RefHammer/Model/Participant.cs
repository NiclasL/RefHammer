namespace RefHammer.Model
{
    public class Participant
    {
        public string Name { get; set; }
        public List<int> Scores { get; set; }

        public Participant(string name)
        {
            Name = name;
            Scores = new List<int>();
        }

        public void AddScore(int score)
        {
            Scores.Add(score);
        }
    }
}
