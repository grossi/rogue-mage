using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleShooter : MonoBehaviour
{

    public ParticleSystem splasher;
    public ParticleSystem shooter;
    List<ParticleCollisionEvent> collisionEvents;


    void Start()
    {
        collisionEvents = new List<ParticleCollisionEvent>();
    }
    void OnParticleCollision(GameObject other) {
        ParticlePhysicsExtensions.GetCollisionEvents(shooter, other, collisionEvents);

        foreach (var e in collisionEvents)
        {
            EmitAtLocation(e);
        }
    }

    void EmitAtLocation(ParticleCollisionEvent e) {
        var emitParams = new ParticleSystem.EmitParams();
        emitParams.position = e.intersection;
        for(var i = 0; i < 3; i++) {
            emitParams.velocity = new Vector3(Random.value, Random.value, 0);
            splasher.Emit(emitParams, 1);
        }
    }
}
