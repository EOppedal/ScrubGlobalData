using System.Linq;
using UnityEngine;

namespace Consensus {
    [CreateAssetMenu(fileName = "MajorityInFavourConsensus", menuName = "Scrubs/GlobalData/Consensus/Create MajorityInFavourConsensus")]
    public class MajorityInFavourConsensus : Consensus  {
        public override bool ConsensusRule() => scriptVotePairs.Select(scriptVotePair => scriptVotePair.vote).Count() > scriptVotePairs.Count / 2;
    }
}