using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountEnemies : MonoBehaviour
{
    public static int enemyCount;
    [SerializeField] GameObject imageNextLevel;

    void Awake()
    {
        enemyCount = 0;
    }

    void Update()
    {
        if (enemyCount <= 0)
        {
            imageNextLevel.SetActive(true);
        }
    }

}
