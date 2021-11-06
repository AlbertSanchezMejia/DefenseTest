using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelsManager : MonoBehaviour
{
    bool theFistPanel = true;
    [SerializeField] GameObject firstPanel;
    [SerializeField] GameObject secondtPanel;

    public static bool isTheFirstGame = true;

    void Start()
    {
        ChangeActivePanel();
        if (isTheFirstGame)
        {
            Invoke("ChangeActivePanel", 4.5f);
            isTheFirstGame = false;
            firstPanel.SetActive(false);
        }
    }

    public void SetActivePanel()
    {
        theFistPanel = !theFistPanel;
        ChangeActivePanel();
    }

    void ChangeActivePanel()
    {
        firstPanel.SetActive(theFistPanel);
        secondtPanel.SetActive(!theFistPanel);
    }

}
