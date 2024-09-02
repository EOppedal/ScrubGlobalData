using System.Linq;
using UnityEngine;

namespace Consensus {
    [CreateAssetMenu(fileName = "MajorityInFavourConsensus", menuName = "Scrubs/GlobalData/Consensus/New MajorityInFavourConsensus")]
    public class MajorityInFavourConsensus : global::Consensus.Consensus  {
        public override bool ConsensusRule() => scriptVotePairs.Select(scriptVotePair => scriptVotePair.vote)
            .Count() > scriptVotePairs.Count / 2;
    }
}