using UnityEngine;
using System.Collections;

public class RotateCamera : MonoBehaviour {
    public float speed;

	void Start () {
	
	}
	
	void Update () {
        this.transform.Rotate(Vector3.up, this.speed * Time.deltaTime);
	}
}
