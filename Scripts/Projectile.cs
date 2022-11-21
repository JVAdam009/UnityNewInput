using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up *Time.deltaTime * 5);

        if (transform.position.y > 20)
        {
            Destroy(gameObject,1f);
        }
    }
    
}
