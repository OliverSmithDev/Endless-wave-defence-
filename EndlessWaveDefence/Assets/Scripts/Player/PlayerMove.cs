using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rb;
    public Transform _camera;
    public GameObject Player;

    public static float moveSpeed = 6f;
    public float CurrentSpeed = 6f;
  

   
    public static bool CanMove = true;

    void Update()
    {
        Vector3 vel = rb.velocity;
        if (vel.magnitude > moveSpeed)
        {
            rb.velocity = vel.normalized * moveSpeed;
            //facing direction
            Debug.DrawLine(_camera.position, transform.forward * 2.5f);
        }

        //moving
        float x = Input.GetAxisRaw("Horizontal") * CurrentSpeed;
        float y = Input.GetAxisRaw("Vertical") * CurrentSpeed;
       

        

        //setting movement
        if(CanMove == true)
        {
            rb.constraints = RigidbodyConstraints.None;
            rb.constraints = RigidbodyConstraints.FreezeRotation;
            Vector3 move = transform.right * x + transform.forward * y;

            rb.velocity = new Vector3(move.x, rb.velocity.y, move.z);
        }
        else if(CanMove == false)
        {
            rb.constraints = RigidbodyConstraints.FreezePosition;
        }

    }

   
}
