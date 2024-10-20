using System.Linq;
using UnityEngine;

namespace Consensus {
    [CreateAssetMenu(fileName = "AllInFavourConsensus", menuName = "Scrubs/GlobalData/Consensus/Create AllInFavourConsensus")]
    public class AllInFavourConsensus : Consensus  {
        public override bool ConsensusRule() => scriptVotePairs.All(scriptVotePair => scriptVotePair.vote);
    }
}