using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner1 : MonoBehaviour
{
  
    public int timeToSpawn = 10;
    private int theTimer;
    public GameObject enemy;
  


    private void FixedUpdate()
    {
        theTimer += 1;
   
            if (theTimer % timeToSpawn == 0)
            {
          
                Instantiate(enemy, transform.position, transform.rotation);
            }
    
       

    }
}
