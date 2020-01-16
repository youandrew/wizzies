using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    [HideInInspector]
    Vector3 destination;
    Rigidbody r;

    bool isGrounded = false;
    public float speed = 1 ;
    


    // Start is called before the first frame update
    void Start()
    {
        r = gameObject.GetComponent<Rigidbody>();
        destination = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(0,Input.GetAxis("Mouse X"),0,Space.World);
        if (isGrounded != true)
        {
           r.AddForce(-transform.up);
           
        }
         if (Input.GetKey(KeyCode.A))
        {
            destination += -transform.right;
            
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            
            destination += -transform.forward;
        }
        if (Input.GetKey(KeyCode.W))
        {
            destination += transform.forward;
            
        }
        if (Input.GetKey(KeyCode.D))
        {
            destination += transform.right;
            
        }
     
        
        
            transform.position = Vector3.Lerp(transform.position, destination, Time.deltaTime * speed);
        
    }
    void OnCollisionEnter(Collision c)
    {
        if(c.gameObject.tag == "ground")
        {
            isGrounded = true;

        }

    }
}
