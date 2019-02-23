using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent (typeof (Collider2D))]
public class TeleporterLoader : MonoBehaviour
{

    public string destinationName;
    public enum TriggerType {Enter, Exit};
    [SerializeField] TriggerType type;

     void OnTriggerEnter2D (Collider2D other)
     {
         if (type != TriggerType.Enter)
             return;
        
        SceneManager.LoadScene(destinationName);
     }
}
