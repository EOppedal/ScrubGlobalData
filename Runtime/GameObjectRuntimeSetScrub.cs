using Attributes;
using UnityEngine;

[CreateAssetMenu(fileName = "GameObjectRuntimeSet", menuName = "Scrubs/GlobalData/Create GameObjectRuntimeSetScrub")]
public class GameObjectRuntimeSetScrub : ScriptableObject {
    [ResetFieldOnExitPlayMode, SerializeField] public RuntimeSet<GameObject> runtimeSet;
}