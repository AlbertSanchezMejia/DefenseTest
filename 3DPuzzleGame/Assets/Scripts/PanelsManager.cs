using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelsManager : MonoBehaviour
{
    bool theFistPanel = true;
    [SerializeField] GameObject firstPanel;
    [SerializeField] GameObject secondtPanel;

    void Start()
    {
        ChangeActivePanel();
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
