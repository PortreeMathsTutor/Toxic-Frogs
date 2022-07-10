using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IfFallOffEdge : MonoBehaviour
{

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (rb.position.y >290f)
        {
          
            if (gameObject.tag == "Team2")
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);


            }
        }

        if (rb.position.y < -100f)
        {
            if (gameObject.tag == "Enemy") { Destroy(gameObject); }
            if (gameObject.tag == "Team2")
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);


            }
        }

    }
}
