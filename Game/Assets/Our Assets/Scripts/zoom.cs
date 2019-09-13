using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoom : MonoBehaviour
{
    private Camera cam;
    private camerafollow c;
    private float zoomin;
    int triggercount = 0;

   /* private void OnTriggerStay(Collider other)
    {
        triggercount++;
        cam = Camera.main; 
        cam.fieldOfView = 37;
        Debug.Log("Trigger");
    }*/
    private void OnTriggerEnter(Collider other)
    {
        c = FindObjectOfType<camerafollow>();
        c.offset = new Vector3(0f, 1f, -5f);

    }
    private void OnTriggerExit(Collider other)
    {
        c = FindObjectOfType<camerafollow>();
        c.offset = new Vector3(0f, 2f, -10f);
    }
    /*private void OnTriggerEnter(Collider other)
    {
        triggercount++;
        if (triggercount % 2 != 0)
        {
            cam = Camera.main;
            cam.fieldOfView -= 30;
        }
        else
        {
            cam.fieldOfView = 57;
        }
        Debug.Log(triggercount);
    }*/

}
