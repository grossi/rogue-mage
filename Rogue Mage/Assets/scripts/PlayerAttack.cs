using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {
    public Joystick joystick;

    public float bulletSpeed = 10f;

    public float cooldown = 0.1f;

    private float cooldownLeft = 0.1f;

    public ParticleSystem shooter;


    private void Update() {
        Vector3 direction = Vector3.right * joystick.Horizontal + Vector3.up * joystick.Vertical;

        cooldownLeft -= Time.deltaTime;

        if (direction != Vector3.zero && cooldownLeft < 0)
        { 
            cooldownLeft = cooldown;
            var emitParams = new ParticleSystem.EmitParams();
            emitParams.velocity = Vector3.Normalize(direction) * bulletSpeed;
            shooter.Emit(emitParams, 1);
        }
    }

    // private void shoot(Vector3 direction) {
    //     GameObject bullet = Instantiate(bulletPrefab, this.transform) as GameObject;

    //     var radDirection = Mathf.Atan2(direction.x, -1f*direction.y) * Mathf.Rad2Deg;

    //     bullet.transform.rotation = Quaternion.AngleAxis(radDirection, Vector3.forward);

    //     bullets.Add(bullet);
    // }
}
