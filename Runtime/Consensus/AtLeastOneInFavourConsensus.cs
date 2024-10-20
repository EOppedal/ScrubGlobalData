using System.Linq;
using UnityEngine;

namespace Consensus {
    [CreateAssetMenu(fileName = "AtLeastOneInFavourConsensus", menuName = "Scrubs/GlobalData/Consensus/Create AtLeastOneInFavourConsensus")]
    public class AtLeastOneInFavourConsensus : Consensus {
        public override bool ConsensusRule() => scriptVotePairs.Any(scriptVotePair => scriptVotePair.vote);
    }
}