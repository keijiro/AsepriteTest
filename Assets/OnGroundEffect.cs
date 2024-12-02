using UnityEngine;
using UnityEngine.VFX;

public sealed class OnGroundEffect : MonoBehaviour
{
    [field:SerializeField] public VisualEffect Target { get; set; }

    public void OnGround() => Target.SendEvent("OnGround");
}
