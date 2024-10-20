using UnityEngine;

[CreateAssetMenu(fileName = "ScrubGlobalFloat", menuName = "Scrubs/GlobalData/Create ScrubGlobalFloat")]
public class ScrubVariableFloat : ScrubVariable<float> {
    public static implicit operator float(ScrubVariableFloat scrubVariable) => scrubVariable.value;
}