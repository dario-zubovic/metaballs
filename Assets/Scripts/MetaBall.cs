using UnityEngine;
using System.Collections;

public class MetaBall : MonoBehaviour {
    public float radius;
    public bool negativeBall;

    [HideInInspector]
    public float factor;

    public virtual void Start() {
        this.factor = (this.negativeBall ? -1 : 1) * this.radius * this.radius;
    }
}
