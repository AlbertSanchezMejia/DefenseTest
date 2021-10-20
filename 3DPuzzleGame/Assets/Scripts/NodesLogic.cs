using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodesLogic : MonoBehaviour
{
    void OnMouseDown()
    {
        bool thereObjectAbove = Physics.Raycast(transform.position, transform.up, 2);

        if (ObjectToMove.objectToMove != null && thereObjectAbove == false)
        {
            ObjectToMove.objectToMove.position = new Vector3(transform.position.x, 0.5f, transform.position.z);
        }
    }

}
