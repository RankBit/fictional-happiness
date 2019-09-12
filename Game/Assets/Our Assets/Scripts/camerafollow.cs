using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public Transform player;
    public float smooth = 9f;
    public Vector3 offset = new Vector3(0f,2f,-10f);
    public float oz;
    void Start()
    {
        
    }

    
    void LateUpdate()
    {
        Vector3 pos = player.position + offset;
        Vector3 smoothpos = Vector3.Lerp(transform.position, pos, smooth * Time.deltaTime);
        transform.position = smoothpos ;
        transform.LookAt(player);
        oz = offset.z;
    }
    
}
