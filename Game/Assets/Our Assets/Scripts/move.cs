using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    [SerializeField]float movespeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement();

    }

    private void movement()
    {
        var deltaX = Input.GetAxis("Horizontal") * Time.deltaTime * movespeed;
        var newXPos = transform.position.x + deltaX;
        transform.position = new Vector3(newXPos, transform.position.y,transform.position.z);
    }
    
   
}
