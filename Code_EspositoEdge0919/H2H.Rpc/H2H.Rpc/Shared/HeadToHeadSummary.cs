using System.Collections.Generic;

namespace H2H.Rpc.Shared
{
    public class PlayedMatch
    {
        public int Winner { get; set; }
        public string WinnerId { get; set; }
        public string Score { get; set; }
        public string Location { get; set; }
        public string Tournament { get; set; }
        public string Category { get; set; }
        public int Year { get; set; }
        public string Round { get; set; }
        public string Surface { get; set; }
        public bool IsOutsideWorldTour { get; set; }
        public string MatchTime { get; set; }
    }

    public class HeadToHeadSummary
    {
        public HeadToHeadSummary()
        {
            Matches = new List<PlayedMatch>();
        }

        public int CircuitId { get; set; }
        public string Id1 { get; set; }
        public string Id2 { get; set; }
        public int Record1 { get; set; }
        public int Record2 { get; set; }
        public List<PlayedMatch> Matches { get; set; }
    }
}