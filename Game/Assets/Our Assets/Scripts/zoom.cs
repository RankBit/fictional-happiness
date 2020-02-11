using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoom : MonoBehaviour
{   // Class Objects
    private Camera cam;
    private camerafollow c;  
    private Player play;

    // Config Para
    int triggercount = 0;
    private float zoomin;

    private void OnTriggerEnter(Collider other)
    {
        c = FindObjectOfType<camerafollow>();
        c.offset = new Vector3(0f, 1f, -5f);
        play = FindObjectOfType<Player>();
        
        play.movement();
    }
    private void OnTriggerExit(Collider other)
    {
        c = FindObjectOfType<camerafollow>();
        c.offset = new Vector3(0f, 2f, -10f);
        
        play.movement();
    }
}
