using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Test : MonoBehaviour
{
    public Rigidbody2D playerRigidbody;
    
    private void FixedUpdate()
    {
        playerRigidbody.velocity = new  Vector2(5, playerRigidbody.velocity.y);
        
        if(Input.GetButtonDown("Fire1"))
        {
            playerRigidbody.AddForce(new Vector2(0, 100));
        }
        
    }

}


