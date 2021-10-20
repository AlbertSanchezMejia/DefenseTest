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
        if (other.gameObject.CompareTag("Bullet"))
        {
            countTheEnemies.enemyCount--;
            if (countTheEnemies.enemyCount <= 0)
            {
                countTheEnemies.imageNextLevel.SetActive(true);
                countTheEnemies.AddNewLevel();
            }

            Destroy(gameObject);
        }

    }

}