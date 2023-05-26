using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject Enemy;
    public GameObject SpawnLocation;
    public LayerMask WalkingPlane;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Spawn();
        }
    }

    void Spawn()
    {
        //cast a ray downwards to check if you can spawn on ground
        if (Physics.Raycast(SpawnLocation.transform.position, Vector3.down, out RaycastHit hit, Mathf.Infinity, WalkingPlane))
        {
            GameObject newEnemy = Instantiate(Enemy, hit.point, Quaternion.Euler(0,0,0));
        } else
        {
            Debug.LogWarning("Failed to spawn object. No ground detected.");
        }
    }
}
