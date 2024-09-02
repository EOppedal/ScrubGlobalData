using System;
using System.Collections.Generic;
using UnityEngine;

namespace Consensus {
    /// <summary>
    /// Users of Consensus are responsible for remove themselves from the list of script vote pairs
    /// </summary>
    [Serializable] public abstract class Consensus : ScriptableObject {
        [SerializeField] protected List<ScriptVotePair> scriptVotePairs = new();

        public bool consensus = true;

        public event Action<bool> OnVoteChange;
        
        
        /// <summary>
        /// Gets called by change vote if not already added manually
        /// </summary>
        /// <param name="scriptVotePair"></param>
        public void AddVote(ScriptVotePair scriptVotePair) {
            scriptVotePairs.Add(scriptVotePair);
            consensus = ConsensusRule();
            OnVoteChange?.Invoke(consensus);
        }
        
        public void ChangeVote(ScriptVotePair scriptVotePair, bool vote) {
            scriptVotePair.vote = vote;

            if (!scriptVotePairs.Contains(scriptVotePair)) {
                AddVote(scriptVotePair);
                return;
            }
            
            consensus = ConsensusRule();
            OnVoteChange?.Invoke(consensus);
        }

        public void DeleteVote(ScriptVotePair scriptVote) => scriptVotePairs.Remove(scriptVote);

        public abstract bool ConsensusRule();

        [Serializable] public class ScriptVotePair {
            public bool vote;
        }
    }
}