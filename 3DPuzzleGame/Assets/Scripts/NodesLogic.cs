using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodesLogic : MonoBehaviour
{
    void OnMouseDown()
    {
        bool canMoveHere = gameObject.CompareTag("Node");
        bool thereSomethingAbove = Physics.Raycast(transform.position, transform.up, 2);
        Vector3 positionToMove = new Vector3(transform.position.x, 0.5f, transform.position.z);

        if (canMoveHere && thereSomethingAbove == false)
        {
            FindObjectOfType<ObjectToMove>().moveTheObjects(positionToMove);
        }
    }

}
