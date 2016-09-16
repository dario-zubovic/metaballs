using UnityEngine;
using System.Collections;

public class Draggable : MonoBehaviour {
    private Rigidbody rigid;
    private float zDist;

	void Start () {
        this.rigid = this.GetComponent<Rigidbody>();
	}
	
	void Update () {
	
	}
    
    void OnMouseDown() {
        this.rigid.useGravity = false;
        this.zDist = Vector3.Distance(Camera.main.transform.position, this.transform.position);
    }
    
    void OnMouseDrag() {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = zDist;
        this.transform.position = Camera.main.ScreenToWorldPoint(mousePos);
    }

    void OnMouseUp() {
        this.rigid.useGravity = true;
        this.rigid.velocity = Vector3.zero;
        this.rigid.angularVelocity = Vector3.zero;
    }
}
