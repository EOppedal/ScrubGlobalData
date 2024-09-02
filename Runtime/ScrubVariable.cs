using UnityEngine;

public abstract class ScrubVariable<T> : ScriptableObject {
    [SerializeField] public T value;
}