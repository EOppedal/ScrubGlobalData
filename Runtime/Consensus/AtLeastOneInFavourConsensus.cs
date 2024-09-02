using System.Linq;
using UnityEngine;

namespace Consensus {
    [CreateAssetMenu(fileName = "AtLeastOneInFavourConsensus", menuName = "Scrubs/GlobalData/Consensus/New AtLeastOneInFavourConsensus")]
    public class AtLeastOneInFavourConsensus : global::Consensus.Consensus {
        public override bool ConsensusRule() => scriptVotePairs.Any(scriptVotePair => scriptVotePair.vote);
    }
}