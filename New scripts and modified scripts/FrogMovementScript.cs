using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogMovementScript : MonoBehaviour
{
    public int frogNumber = 0;
 private float theTimer;
    private GameObject player;
    private GameObject diamond;
    private Rigidbody rb;

    private void Start()
    {
     player = GameObject.FindGameObjectWithTag("Team2");
       diamond = GameObject.FindGameObjectWithTag("Finish");
        rb = GetComponent<Rigidbody>();
        transform.LookAt(player.transform);
        rb.AddForce(transform.forward * 400);
        theTimer = Mathf.FloorToInt(transform.position.x);
    }
    private void FixedUpdate()
    {
  theTimer +=1;
        if (frogNumber == 3) {
            Vector3 direction = transform.position - diamond.transform.position;
           transform.rotation = Quaternion.LookRotation(direction);
            rb.AddForce(transform.forward * 12);
    
            if (theTimer % 27 == 0)
            {
                transform.LookAt(player.transform);
                rb.AddForce(transform.forward * 30);
            }
        }
  
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ground")
        {
            if (frogNumber == 0)
            {
                if (theTimer % 3 == 0) { transform.Rotate(0, 10, 0); }
                if (theTimer % 9 == 0) { transform.Rotate(0, -30, 0); }
            }
 
            if (theTimer % 2 == 0)
            {
                transform.LookAt(player.transform);
            }

            rb.AddForce(transform.forward * 60);
            rb.AddForce(transform.up * 100);


        }
       
    }
   
}
