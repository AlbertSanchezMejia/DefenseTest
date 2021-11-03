using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplayManager : MonoBehaviour
{
    CountEnemies countTheEnemies;

    void Start()
    {
        countTheEnemies = FindObjectOfType<CountEnemies>();
        countTheEnemies.enemyCount++;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            countTheEnemies.enemyCount--;
        }

        if (other.gameObject.CompareTag("Muros"))
        {
            if (countTheEnemies.enemyCount <= 0)
            {
                countTheEnemies.PassedTheLevel();
                gameObject.SetActive(false);
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }

    }

}
