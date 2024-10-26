using System.Linq;
using UnityEngine;

namespace Consensus {
    [CreateAssetMenu(fileName = nameof(AllInFavourConsensus), menuName = "Scriptable Objects/GlobalData/Consensus/Create " + nameof(AllInFavourConsensus))]
    public class AllInFavourConsensus : Consensus  {
        public override bool ConsensusRule() => scriptVotePairs.All(scriptVotePair => scriptVotePair.vote);
    }
}