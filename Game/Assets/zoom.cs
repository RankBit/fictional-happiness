using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoom : MonoBehaviour
{
    
    
    
    private void OnTriggerEnter(Collider other)
    {
        GetComponent<camerafollow>().offset = new Vector3(0f,2f,-6.5f);
        
    }
         
}
