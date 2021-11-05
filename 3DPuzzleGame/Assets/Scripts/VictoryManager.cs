using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryManager : MonoBehaviour
{
    [HideInInspector] public int enemyAmount = 0;
    public GameObject buttonNextLevel;
    [SerializeField] int sceneToAdd;

    void Start()
    {
        GameObject[] Enemies = GameObject.FindGameObjectsWithTag("Enemy");
        enemyAmount = Enemies.Length;
    }

    public void Win()
    {
        buttonNextLevel.SetActive(true);
        if (SelecLevelManager.levelsPlayables < sceneToAdd) SelecLevelManager.levelsPlayables = sceneToAdd;
    }

    public void Lose()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


}
