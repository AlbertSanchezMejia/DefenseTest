using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollisions : MonoBehaviour
{
    CountEnemies countTheEnemies;

    void Start()
    {
        countTheEnemies = FindObjectOfType<CountEnemies>();
        countTheEnemies.enemyCount++;
    }

    void OnTriggerEnter(Collider other)
    {
        countTheEnemies.enemyCount--;
        if (countTheEnemies.enemyCount <= 0) countTheEnemies.imageNextLevel.SetActive(true);

        Destroy(gameObject);

    }

}