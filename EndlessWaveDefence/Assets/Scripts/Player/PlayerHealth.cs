using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] public float Health;

    public bool CanDamage;
    private IEnumerator coroutine;

    public float MaxHealth;
    public float HealthRegen;
    public bool canregen;
    public float RegenTimer;
    public Collider ObjectCollider;
    public float RegenMulti;
    public float Armour = 0.9f;
    public float EnemyDamage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        HealthRegen = Health / 100 * RegenMulti;

        if(canregen == true && Health <= MaxHealth)
        {
            StartCoroutine(RegainHealthOverTime());
        }

        RegenTimer += Time.deltaTime;

        if(RegenTimer >= 30)
        {
            canregen = true;
            RegenTimer = 0f;
        }

        if (CanDamage == true)
        {
            coroutine = StartDamage();
            StartCoroutine(coroutine);

            CanDamage = false;
        }


        if (Health <= 0)
        {
            GameOver();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Enemy")
        {
            CanDamage = true;
            print("Tagged");

            


        }
    }

    private void OnTriggerExit(Collider other)
    {
        CanDamage = false;
        if (other.tag == "Enemy")
        {
            CanDamage = false;
        }
    }

    IEnumerator StartDamage()
    {

        print("HitEnemy");
        Health -= (EnemyDamage * Armour);

        // enemyhealth.HealthEnemy -= playerdamge.Damage;
        print("Damaged");
        yield return new WaitForSeconds(.2f);
        



    }

    private IEnumerator RegainHealthOverTime()
    {
        yield return new WaitForSeconds(1f);
        Health *= HealthRegen;
        print("Regen");
        canregen = false;
    }


    public void GameOver()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
