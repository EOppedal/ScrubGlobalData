using System.Linq;

namespace Consensus.Scripts {
    public class AllInFavourConsensus : Consensus {
        public override bool ConsensusRule() => scriptVotePairs.All(b => b.vote);
    }
}