using System.Linq;

namespace Consensus.Scripts {
    public class AtLeastOneInFavourConsensus : Consensus {
        public override bool ConsensusRule() => scriptVotePairs.Any(scriptVotePair => scriptVotePair.vote);
    }
}