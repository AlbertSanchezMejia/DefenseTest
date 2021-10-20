using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelecLevelManager : MonoBehaviour
{
    public static int levelsPlayables = 1;
    [SerializeField] GameObject[] levelButtons;

    void Start()
    {
        for (int i = levelsPlayables; i < levelButtons.Length; i++)
        {
            levelButtons[i].SetActive(false);
        }
    }

}
