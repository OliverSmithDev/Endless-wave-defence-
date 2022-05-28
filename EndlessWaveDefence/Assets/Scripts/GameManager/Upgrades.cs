using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrades : MonoBehaviour
{
    private PlayerDamage playerdamage;
    public float DamageMulti;

    private AreaRange arearange;
    

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

    }

    void Fire()
    {

    }

    void Lightning()
    {

    }

    void AcidRain()
    {

    }

    void Health()
    {

    }

    void Range() // Range of attacks
    {
        arearange.radiusMulti *= 1.25f;
        arearange.CanIncrease = true;
    }

    void Regen()
    {

    }

    void XPMulti()
    {

    }

    void Boot()
    {

    }

    void Armour()
    {

    }

    void Cloak()
    {

    }


}
