using UnityEngine;

[CreateAssetMenu(fileName = "ScrubVariableInt", menuName = "Scrubs/GlobalData/Create ScrubVariableInt")]
public class ScrubVariableInt : ScrubVariable<int> {
    public static implicit operator int(ScrubVariableInt scrubVariable) => scrubVariable.value;
}