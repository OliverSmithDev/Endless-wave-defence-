using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightning : MonoBehaviour
{
    public float LightningDamage;
    public bool CanDamage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(CanDamage == true)
        {
            StartCoroutine(LightningAttack());
        }
    }


    IEnumerator LightningAttack()
    {
        yield return new WaitForSeconds(1f);
    }
}
