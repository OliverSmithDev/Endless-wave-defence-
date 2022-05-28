using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaRange : MonoBehaviour
{
    private PlayerDamage playerdamge;
    private EnemyHealth enemyhealth;
    public bool CanDamage;
    public GameObject HitObject;
    private IEnumerator coroutine;
    public float AreaDamage = 1f;
    public float radiusMulti = 0.5f;
    public bool CanIncrease;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(CanIncrease == true)
        {
            transform.localScale *= radiusMulti;
            CanIncrease = false;
        }

        
        if (CanDamage == true)
        {
            coroutine = StartDamage();
            StartCoroutine(coroutine);
            
            CanDamage = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            CanDamage = true;
            print("Tagged");
            
            HitObject = other.gameObject;
            

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Enemy")
        {
            CanDamage = false;
        }
    }

    IEnumerator StartDamage()
    {
        
            print("HitEnemy");
            HitObject.GetComponent<EnemyHealth>().HealthEnemy -= AreaDamage;
           
           // enemyhealth.HealthEnemy -= playerdamge.Damage;
            print("Damaged");
            yield return new WaitForSeconds(.2f);
            CanDamage = true;
        
       

    }
}
