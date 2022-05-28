using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] public float Health;

    public bool CanDamage;
    private IEnumerator coroutine;

    public Collider ObjectCollider;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
        Health -= 1;

        // enemyhealth.HealthEnemy -= playerdamge.Damage;
        print("Damaged");
        yield return new WaitForSeconds(.2f);
        



    }


    public void GameOver()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
