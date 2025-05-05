using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall :MonoBehaviour
{
    private Rigidbody rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        //rigid.AddForce(Vector3.up * 50, ForceMode.Impulse);
        //rigid.linearVelocity = new Vector3 (2, 4, 3);
    }

    void FixedUpdate()
    {
        
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 vec = new Vector3(h, 0, v);
        
        rigid. AddForce(vec, ForceMode. Impulse);
        
        /*if (Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector3.up * 50, ForceMode.Impulse);
            Debug.Log(rigid.linearVelocity);
        }
        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"),
            0, Input.GetAxisRaw("Vertical"));
        rigid. AddForce(vec, ForceMode.Impulse);*/


        //rigid.linearVelocity = new Vector3 (2, 4, 3);
        //rigid.velocity = Vector3.forward; 

        /* if (Input.GetButtonDown("Jump"))
         {
             rigid.AddForce(Vector3.up * 25, ForceMode.Impulse);
         }

         Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
         rigid.AddForce(vec, ForceMode.Impulse);*/
        
        //회전력
        
        //rigid.AddTorque(Vector3.up * 50, ForceMode.Impulse);
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.name == "Cube")
            rigid.AddForce(Vector3.up * 4, ForceMode.Impulse) ;
    }

    /*void Update()
    {
        
    }*/
    
    public void Jump()
    {
        rigid.AddForce(Vector3.up * 200, ForceMode. Impulse);
    }


}
