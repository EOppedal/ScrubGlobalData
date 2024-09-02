using System.Linq;
using UnityEngine;

namespace Consensus {
    [CreateAssetMenu(fileName = "AllInFavourConsensus", menuName = "Scrubs/GlobalData/Consensus/New AllInFavourConsensus")]
    public class AllInFavourConsensus : global::Consensus.Consensus  {
        public override bool ConsensusRule() => scriptVotePairs.All(scriptVotePair => scriptVotePair.vote);
    }
}