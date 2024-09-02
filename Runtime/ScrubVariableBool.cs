using UnityEngine;

[CreateAssetMenu(fileName = "ScrubGlobalBool", menuName = "Scrubs/GlobalData/New ScrubGlobalBool")]
public class ScrubVariableBool : ScrubVariable<bool> {
    public static implicit operator bool(ScrubVariableBool scrubVariable) => scrubVariable.value;
}