using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
  
    public GameObject Enemy;
    public bool CanSpawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(CanSpawn == true)
        {
            SpawnEnemy();
            CanSpawn = false;
        }
    }

    public void SpawnEnemy()
    {
        Bounds bounds = GetComponent<Collider>().bounds;
        float offsetX = Random.Range(-bounds.extents.x, bounds.extents.x);
        float offsetY = Random.Range(-bounds.extents.y, bounds.extents.y);
        float offsetZ = Random.Range(-bounds.extents.z, bounds.extents.z);

        GameObject newEnemy = GameObject.Instantiate(Enemy);
        newEnemy.transform.position = bounds.center + new Vector3(offsetX, offsetY, offsetZ);
        
    }
}
