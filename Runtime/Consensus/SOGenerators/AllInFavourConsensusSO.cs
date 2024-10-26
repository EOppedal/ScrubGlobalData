using System.Linq;
using UnityEngine;

namespace Consensus {
    [CreateAssetMenu(fileName = nameof(AllInFavourConsensusSO), menuName = "Scriptable Objects/GlobalData/Consensus/Create " + nameof(AllInFavourConsensusSO))]
    public class AllInFavourConsensusSO : Consensus  {
        public override bool ConsensusRule() => scriptVotePairs.All(scriptVotePair => scriptVotePair.vote);
    }
}