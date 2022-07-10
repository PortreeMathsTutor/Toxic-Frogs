using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DieIfEnemyTouchesYou : MonoBehaviour
{
    [SerializeField]
    private ScoreManager scoreManager;

void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy")
        {
                         scoreManager.ResetBullets();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
   
}
