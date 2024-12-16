using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class flyboymovement : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    
   
    //move code//
    void FixedUpdate()
    {   

         //forward
      if (Input.GetKey(KeyCode.W)){

        rb.AddForce(0,0,1f,ForceMode.Impulse);

        
      }
      //backward
      if (Input.GetKey(KeyCode.S)){

        rb.AddForce(0,0,-1f,ForceMode.Impulse);

    }
      //left
    if (Input.GetKey(KeyCode.A)){

        rb.AddForce(-1,0,0,ForceMode.Impulse);

    }
    // backward
if (Input.GetKey(KeyCode.D)){

        rb.AddForce(1,0,0,ForceMode.Impulse);

    }
    //much needed brake
    if (Input.GetKey(KeyCode.Space)){
      rb.velocity *= 0.9f;
    }

      // up
    if (Input.GetKey(KeyCode.Q)){

        rb.AddForce(0,1,0,ForceMode.Impulse);

    }

  //down
if (Input.GetKey(KeyCode.E)){

        rb.AddForce(0,-1,0,ForceMode.Impulse);

    }

}




}

