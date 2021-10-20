using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowers : MonoBehaviour
{
    Camera gameCamera;
    [SerializeField] GameObject arrowPrefab;

    void Start()
    {
        gameCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    void ChangeArrowPosition()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = gameCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit) && hit.transform.name.Substring(0,4) == "Node")
            {
                arrowPrefab.transform.position = new Vector3(hit.transform.position.x, 0.5f, hit.transform.position.z);
            }
        }

    }

    void Update()
    {
        ChangeArrowPosition();
    }

}