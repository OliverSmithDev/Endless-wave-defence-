using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrades : MonoBehaviour
{
    private PlayerDamage playerdamage;
    public float DamageMulti;

    private AreaRange arearange;
    private Spike spike;
    private PlayerMove playermove;
    private PlayerXP playerxp;
    private PlayerHealth playerhealth;
    private Lightning lightning;

    private GameObject ArmourOBJ;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void Damage()
    {
        playerdamage.Damage *= DamageMulti;
    }

    void Spear()
    {

    }

    void Arcane() // AOE Ranges attack
    {
        arearange.AreaDamage *= 1.25f;
        
    }

    void Missilies()
    {

    }

    void Spikes()
    {
        spike.SpikeDamageFloat *= 1.25f;
    }

    void Fire()
    {

    }

    void Lightning()
    {
        lightning.LightningDamage *= 1.25f;
    }

    void AcidRain()
    {

    }


    // Non Combat

    void Health()
    {
        playerhealth.MaxHealth *= 1.25f;
    }

    void Range() // Range of attacks
    {
        arearange.radiusMulti *= 1.25f;
        arearange.CanIncrease = true;
    }

    void Regen()
    {
        playerhealth.RegenMulti +=1;
    }

    void XPMulti()
    {
        playerxp.xpgained *= 1.25f;
    }

    void Boot()
    {
        playermove.CurrentSpeed *= 1.25f;
    }

    void Armour()
    {
        ArmourOBJ = GameObject.Find("ExtraArmour");
        playerhealth.Armour -= 0.05f;

        if (playerhealth.Armour <= 0.1f)
        {
            ArmourOBJ.gameObject.tag = ("FullyUpgraded");
        }
    }

    void Cloak()
    {

    }


}
