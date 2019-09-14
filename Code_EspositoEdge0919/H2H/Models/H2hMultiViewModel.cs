using System.Collections.Generic;

namespace H2H.Models
{
    public class H2HMultiViewModel
    {
        public H2HMultiViewModel()
        {
            Matches = new List<PlayerScore>();
        }

        public List<PlayerScore> Matches { get; set; }
    }

    public class PlayerScore
    {
        public PlayerScore(string p1, uint w1, string p2, uint w2)
        {
            Player1 = p1;
            Player2 = p2;
            Won1 = w1;
            Won2 = w2;
        }

        public string Player1 { get; set; }
        public uint Won1 { get; set; }
        public string Player2 { get; set; }
        public uint Won2 { get; set; }
    }
}