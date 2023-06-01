    using System.Collections.Generic;
namespace RefHammer.Model
{
    public class Tournament
    {
        public string Name { get; set; }
        public List<Participant> Participants { get; set; }
        public List<Round> Rounds { get; set; }

        public Tournament(string name)
        {
            Name = name;
            Participants = new List<Participant>();
            Rounds = new List<Round>();
        }

        public void AddParticipant(Participant participant)
        {
            Participants.Add(participant);
        }

        public void AddRound(Round round)
        {
            Rounds.Add(round);
        }
    }


}
