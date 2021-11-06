using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialHand : MonoBehaviour
{
    [SerializeField] GameObject handMakeFalse;
    [SerializeField] GameObject handMakeTrue;

    void OnMouseDown()
    {
        ChangeTutorialHand();
    }

    public void ChangeTutorialHand()
    {
        if (handMakeTrue != null) { handMakeTrue.SetActive(true); }
        handMakeFalse.SetActive(false);
        Destroy(this);
    }

}
