using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogSpawner : MonoBehaviour
{
    private int counter;
    public int numberOfFrogsToSpawn=5;
 public int timeToSpawn =10;
    private int theTimer;
    public GameObject frog;
    public GameObject toxFrogGoast;


    private void FixedUpdate()
    {
        theTimer += 1;
        if (counter<numberOfFrogsToSpawn) {
            if (theTimer % timeToSpawn == 0)
            {
                counter += 1;
                Instantiate(frog, transform.position, transform.rotation);
            }
        }
        if (counter==numberOfFrogsToSpawn) { toxFrogGoast.SetActive(false); }
        
    }
}