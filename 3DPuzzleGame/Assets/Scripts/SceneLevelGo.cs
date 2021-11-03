using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLevelGo : MonoBehaviour
{
    [SerializeField] int sceneToGo;

    public void GoToScene()
    {
        SceneManager.LoadScene(sceneToGo);
    }

}
