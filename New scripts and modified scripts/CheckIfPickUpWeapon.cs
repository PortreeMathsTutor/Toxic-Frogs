using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIfPickUpWeapon : MonoBehaviour
{
    [SerializeField]
    private ScoreManager scoreManager;
    public int gunNumber=1;
    private int weaponIndex;
 

    // Start is called before the first frame update
    void Start()
    {
        weaponIndex = scoreManager.weapon;
        if (weaponIndex == gunNumber) { Destroy(gameObject); }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Team2")
        {
            scoreManager.SetWeapon(gunNumber);
          
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
     
    }
}
