using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EquippedWeapon
{
    AK47,
    DessertEagle,
    RocketLauncher
}
public class GameManager : MonoBehaviour
{
    [Header("Player Stats")]
    public float basePlayerDamage;
    public float finalPlayerDamage;

    [Header("Equipped Weapon")]
    public EquippedWeapon eWeapon;

    [Header("Experience")]
    public float expToAdd;
    public float maxXP;
    public float currentXP;
    public int playerLevel;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    //void Update()
    //{
    //   if (Input.GetKeyDown(KeyCode.Mouse0)) 
    //   {
    //        DamagePowerUp_FeedingFrenzy();
    //   }
    //}

    private void OnValidate()
    {
        DamageSystem damageSystem = new DamageSystem();
        switch (eWeapon)
        {
            case EquippedWeapon.AK47:
                finalPlayerDamage = basePlayerDamage + damageSystem.Damage_AK47;
                break;
          
            case EquippedWeapon.DessertEagle:
                finalPlayerDamage = basePlayerDamage + damageSystem.Damage_DessertEagle;
                break;
           
            case EquippedWeapon.RocketLauncher:
                finalPlayerDamage = basePlayerDamage + damageSystem.Damage_RocketLauncher;
                break;
                
                default:
                break;
        }
    }

    public void DamagePowerUp_FeedingFrenzy()
    {
        PowerUps powerUps = new();
        finalPlayerDamage += powerUps.FeedingFrenzy;
    }

    public void DamagePowerUp_WellFed()
    {
        PowerUps powerUps = new();
        float powerUpPlayerDamage = (finalPlayerDamage * (powerUps.WellFed / 1000));
        finalPlayerDamage = powerUpPlayerDamage + finalPlayerDamage;
    }

    public void ResetValues()
    {
        DamageSystem weapon = new DamageSystem();
        switch (eWeapon)
        {
            case EquippedWeapon.AK47:
                finalPlayerDamage = basePlayerDamage + weapon.Damage_AK47;
                break;

            case EquippedWeapon.DessertEagle:
                finalPlayerDamage = basePlayerDamage + weapon.Damage_DessertEagle;
                break;

            case EquippedWeapon.RocketLauncher:
                finalPlayerDamage = basePlayerDamage + weapon.Damage_RocketLauncher;
                break;

            default:
                break;
        }
    }
}
