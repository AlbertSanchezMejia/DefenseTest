using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountEnemies : MonoBehaviour
{
    [HideInInspector] public int enemyCount = 0;
    public GameObject imageNextLevel;
    [SerializeField] int sceneToAdd;

    public void PassedTheLevel()
    {
        imageNextLevel.SetActive(true);
        if (SelecLevelManager.levelsPlayables < sceneToAdd)
        {
            SelecLevelManager.levelsPlayables = sceneToAdd;
        }
    }

}
