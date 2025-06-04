using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CircleMovement : MonoBehaviour
{

    private Rigidbody2D circleRigidbody;
    public Vector2 forwardSpeed;
    public float jumpPower;
    private bool didJump;

    // Start is called before the first frame update
    void Start()
    {
        circleRigidbody = this.GetComponent<Rigidbody2D>();
        
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            didJump = true;
        }

    }

    void FixedUpdate()
    {
        circleRigidbody.AddForce(forwardSpeed);

        if(didJump)
        {
            circleRigidbody.velocity = new Vector2(circleRigidbody.velocity.x, jumpPower);
            didJump = false;
        }
 
    }
}
