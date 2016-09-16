using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
    public float radius;
    public bool negativeBall;

    [HideInInspector]
    public float radiusSq;

    public virtual void Start() {
        this.radiusSq = (this.negativeBall ? -1 : 1) * this.radius * this.radius;
    }
}
