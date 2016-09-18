using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Light))]
public class MetaLight : MonoBehaviour {
    public MetaBall linkedMetaball;
    public float intensity;

    private float phaseShift;
    private Light lightComponent;

    void Start () {
        this.phaseShift = Random.Range(0, Mathf.PI);
        this.lightComponent = this.GetComponent<Light>();
    }

    void Update () {
        this.lightComponent.intensity = this.intensity * (this.linkedMetaball.transform.localPosition.magnitude + (1 + Mathf.Sin(this.phaseShift + Time.time/2)));
	}
}
