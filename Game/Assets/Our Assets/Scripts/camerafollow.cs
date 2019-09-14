using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{   // Class Objects/ Cached Reference
    public Transform player;

    //Config Para
    public float smooth = 9f;
    public Vector3 offset = new Vector3(0f,2f,-10f);

    void LateUpdate()
    {
        
        Vector3 pos = player.position + offset;
        Vector3 smoothpos = Vector3.Lerp(transform.position, pos, smooth * Time.deltaTime);
        transform.position = smoothpos ;
        transform.LookAt(player);
        
    }
    
}
