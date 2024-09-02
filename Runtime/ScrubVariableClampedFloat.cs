using UnityEngine;

[CreateAssetMenu(fileName = "ScrubGlobalClampedFloat", menuName = "Scrubs/GlobalData/New ScrubGlobalClampedFloat")]
public class ScrubVariableClampedFloat : ScrubVariable<ClampedFloat> {
    public static ScrubVariableClampedFloat operator +(ScrubVariableClampedFloat scrubVariable, float amount) {
        scrubVariable.value += amount;
        return scrubVariable;
    }

    public static ScrubVariableClampedFloat operator -(ScrubVariableClampedFloat scrubVariable, float amount) {
        scrubVariable.value -= amount;
        return scrubVariable;
    }
}