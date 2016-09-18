using UnityEngine;
using System.Collections;

public class BouncingBall : MetaBall {
    public float speed;

    private Container container;
    private Vector3 direction;

    public override void Start() {
        base.Start();
        this.direction = Random.onUnitSphere;
        this.container = this.GetComponentInParent<Container>();
    }

    public void Update() {
        this.updatePosition(Time.deltaTime);
    }

    public void updatePosition(float dt) {
        float posX = this.transform.position.x, posY = this.transform.position.y, posZ = this.transform.position.z;
        Vector3 containerPosition = this.container.transform.position;
        Vector3 containerScale = this.container.transform.localScale;

        if(posX + this.radius + this.container.safeZone > containerPosition.x + containerScale.x / 2) {
            posX -= 0.01f;
            this.direction = Vector3.Reflect(this.direction, Vector3.left);
        } else if(posX - this.radius - this.container.safeZone < containerPosition.x - containerScale.x / 2) {
            posX += 0.01f;
            this.direction = Vector3.Reflect(this.direction, Vector3.right);
        }

        if(posY + this.radius + this.container.safeZone > containerPosition.y + containerScale.y / 2) {
            posY -= 0.01f;
            this.direction = Vector3.Reflect(this.direction, Vector3.down);
        } else if(posY - this.radius - this.container.safeZone < containerPosition.y - containerScale.y / 2) {
            posY += 0.01f;
            this.direction = Vector3.Reflect(this.direction, Vector3.up);
        }

        if(posZ + this.radius + this.container.safeZone > containerPosition.z + containerScale.z / 2) {
            posZ -= 0.01f;
            this.direction = Vector3.Reflect(this.direction, Vector3.back);
        } else if(posZ - this.radius - this.container.safeZone < containerPosition.z - containerScale.z / 2) {
            posZ += 0.01f;
            this.direction = Vector3.Reflect(this.direction, Vector3.forward);
        }

        this.transform.position = new Vector3(posX, posY, posZ) + this.direction * speed * dt;
    }
}
