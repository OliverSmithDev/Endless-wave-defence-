using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float HealthEnemy;
    public float HealthMulti = 1.5f;
    public float Timer;
    public float MaxTimer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Timer += Time.deltaTime;

        if (Timer >= MaxTimer)
        {
            HealthEnemy = HealthEnemy * HealthMulti;
            Timer = 0;
        }
    }
}
