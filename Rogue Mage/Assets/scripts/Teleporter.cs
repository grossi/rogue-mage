using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (Collider2D))]
public class Teleporter : MonoBehaviour
{

    public GameObject destination;
    public enum TriggerType {Enter, Exit};
    [SerializeField] TriggerType type;
    
    public ParticleSystem teleportAnimation;

     void OnTriggerEnter2D (Collider2D other)
     {
         if (type != TriggerType.Enter)
             return;
        
        teleportAnimation.Play();
        
        other.transform.position = destination.transform.position;
     }
 
     void OnTriggerExit2D (Collider2D other)
     {
         if (type != TriggerType.Exit)
             return;

        other.transform.position = destination.transform.position;
     }
}
