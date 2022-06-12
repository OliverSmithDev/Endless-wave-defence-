using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrades : MonoBehaviour
{
    public PlayerDamage playerdamage;
    public float DamageMulti;

    public AreaRange arearange;
    public Spike spike;
    public PlayerMove playermove;
    public PlayerXP playerxp;
    public PlayerHealth playerhealth;
    public Lightning lightning;

    private GameObject ArmourOBJ;

    private GameObject Player;
    private GameObject AreaRangeObj;
    private GameObject Enemy;
    private GameObject PlayerHealthOBJ;



    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        AreaRangeObj = GameObject.FindGameObjectWithTag("AreaRange");
        PlayerHealthOBJ = GameObject.FindGameObjectWithTag("PlayerHealth");
        

        playerdamage = Player.GetComponent<PlayerDamage>();
        arearange = AreaRangeObj.GetComponent<AreaRange>();
       
        playermove = Player.GetComponent<PlayerMove>();
        playerxp = Player.GetComponent<PlayerXP>();
        playerhealth = PlayerHealthOBJ.GetComponent<PlayerHealth>();
        lightning = Player.GetComponent<Lightning>();
    }

    // Update is called once per frame
    void Update()
    {
        Enemy = GameObject.FindGameObjectWithTag("Enemy");
        spike = Enemy.GetComponent<Spike>();
    }


   public void Damage()
    {
        playerdamage.Damage *= DamageMulti;
        playerxp.MenuUI.SetActive(false);
        playerxp.MenuActive = false;
        Time.timeScale = 1f;
        playerxp.PickUpgrade();
    }

    public void Spear()
    {

    }

    public void Arcane() // AOE Ranges attack
    {
        arearange.AreaDamage *= 1.25f;
        playerxp.MenuUI.SetActive(false);
        playerxp.MenuActive = false;
        Time.timeScale = 1f;
        playerxp.PickUpgrade();

    }

    void Missilies()
    {
        playerxp.MenuUI.SetActive(false);
        playerxp.MenuActive = false;
        Time.timeScale = 1f;
        playerxp.PickUpgrade();
    }

    public void Spikes()
    {
        spike.CanActivateSpike = true;
        spike.SpikeDamageFloat *= 1.25f;
        playerxp.MenuUI.SetActive(false);
        playerxp.MenuActive = false;
        Time.timeScale = 1f;
        playerxp.PickUpgrade();
    }

    void Fire()
    {
        playerxp.MenuUI.SetActive(false);
        playerxp.MenuActive = false;
        Time.timeScale = 1f;
        playerxp.PickUpgrade();
    }

    void Lightning()
    {
        lightning.LightningDamage *= 1.25f;
        playerxp.MenuUI.SetActive(false);
        playerxp.MenuActive = false;
        Time.timeScale = 1f;
        playerxp.PickUpgrade();
    }

    void AcidRain()
    {
        playerxp.MenuUI.SetActive(false);
        playerxp.MenuActive = false;
        Time.timeScale = 1f;
        playerxp.PickUpgrade();
    }


    // Non Combat

    void Health()
    {
        playerhealth.MaxHealth *= 1.25f;
        playerxp.MenuUI.SetActive(false);
        playerxp.MenuActive = false;
        Time.timeScale = 1f;
        playerxp.PickUpgrade();
    }

    void Range() // Range of attacks
    {
        arearange.radiusMulti *= 1.25f;
        arearange.CanIncrease = true;
        playerxp.MenuUI.SetActive(false);
        playerxp.MenuActive = false;
        Time.timeScale = 1f;
        playerxp.PickUpgrade();
    }

    void Regen()
    {
        playerhealth.RegenMulti +=1;
        playerxp.MenuUI.SetActive(false);
        playerxp.MenuActive = false;
        Time.timeScale = 1f;
        playerxp.PickUpgrade();
    }

    void XPMulti()
    {
        playerxp.xpgained *= 1.25f;
        playerxp.MenuUI.SetActive(false);
        playerxp.MenuActive = false;
        Time.timeScale = 1f;
        playerxp.PickUpgrade();
    }

    void Boot()
    {
        playermove.CurrentSpeed *= 1.25f;
        playerxp.MenuUI.SetActive(false);
        playerxp.MenuActive = false;
        Time.timeScale = 1f;
        playerxp.PickUpgrade();
    }

    void Armour()
    {
        ArmourOBJ = GameObject.Find("ExtraArmour");
        playerhealth.Armour -= 0.05f;

        if (playerhealth.Armour <= 0.1f)
        {
            ArmourOBJ.gameObject.tag = ("FullyUpgraded");
        }
        playerxp.MenuUI.SetActive(false);
        playerxp.MenuActive = false;
        Time.timeScale = 1f;
        playerxp.PickUpgrade();
    }

    void Cloak()
    {
        playerxp.MenuUI.SetActive(false);
        playerxp.MenuActive = false;
        Time.timeScale = 1f;
        playerxp.PickUpgrade();
    }


    void IncreaseEnemyHealth()
    {
        
    }

}
