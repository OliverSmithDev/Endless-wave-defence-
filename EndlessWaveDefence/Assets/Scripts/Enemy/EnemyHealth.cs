using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float HealthEnemy;
    public float HealthMulti = 1.5f;
    public float Timer;
    public GameManager gamemanager;
    public GameObject XP;

    // Start is called before the first frame update
    void Start()
    {
        HealthEnemy = gamemanager.HealthEnemy;
    }

    // Update is called once per frame
    void Update()
    {
        if(HealthEnemy <= 0)
        {
            EnemyDeath();
        }
    }

    void EnemyDeath()
    {
        Instantiate(XP, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
