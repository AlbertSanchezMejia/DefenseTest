using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletVictory : MonoBehaviour
{
    VictoryManager vManager;

    void Start()
    {
        vManager = FindObjectOfType<VictoryManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy")) vManager.enemyAmount--;

        if (other.gameObject.CompareTag("Muros"))
        {
            if (vManager.enemyAmount > 0) vManager.Lose();
            else {
                vManager.Win();
                gameObject.SetActive(false);
            }
        }
    }

}
