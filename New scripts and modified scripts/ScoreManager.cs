using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "ScoreManager")]
public class ScoreManager : ScriptableObject
{

    public int score;
    public int bulletsInTheGun;
  public int weapon;

    private void OnEnable()
    {
        score = 0;
        weapon = 0;
    }
    public void SetWeapon(int weaponNumber)
    {
        weapon = weaponNumber;
    }
    public void AddScore(int amount)
    {
        score += amount;
    }
    public void AddBullets(int amountOfBullets)
    {
        bulletsInTheGun += amountOfBullets;
    }
    public void ResetBullets()
    {
        bulletsInTheGun = 6;
    }
}