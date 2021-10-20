using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollisions : MonoBehaviour
{
    void Start()
    {
        CountEnemies.enemyCount++;
    }

    void OnTriggerEnter(Collider other)
    {
        CountEnemies.enemyCount--;
        Destroy(gameObject);
    }

}
