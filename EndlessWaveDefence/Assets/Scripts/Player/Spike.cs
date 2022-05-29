using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{

    public float SpikeDamageFloat;
    public float maxtimer;
    public GameObject SpikePrefab;
    public float SpawnTimer;
    public EnemyHealth enemyhealth;
    private GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("PlayerGround");
    }

    // Update is called once per frame
    void Update()
    {
        SpawnTimer += Time.deltaTime;

        if(SpawnTimer >= maxtimer)
        {
            SpawnSpike();
            SpawnTimer = 0;
        }
    }


    void SpawnSpike()
    {
        Instantiate(SpikePrefab, Player.transform.position, Quaternion.identity);
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Spike")
        {
            
            SpikeDamage();
           

        }
    }

    public void SpikeDamage()
    {
        print("SpikeDamaged");
        enemyhealth.HealthEnemy -= SpikeDamageFloat;
        
    }
}
