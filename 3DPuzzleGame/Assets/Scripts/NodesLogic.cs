using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodesLogic : MonoBehaviour
{
    void OnMouseDown()
    {
        if (ObjectToMove.objectToMove != null)
        {
            ObjectToMove.objectToMove.position = new Vector3(transform.position.x, 0.5f, transform.position.z);
        }
    }

}
