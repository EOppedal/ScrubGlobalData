using UnityEngine;

[CreateAssetMenu(fileName = "GameObjectRuntimeSet", menuName = "Scrubs/GlobalData/New GameObjectRuntimeSetScrub")]
public class GameObjectRuntimeSetScrub : ScriptableObject {
    [SerializeField] public RuntimeSet<GameObject> runtimeSet;
}