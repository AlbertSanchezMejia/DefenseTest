using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeTheObjectToMove : MonoBehaviour
{
    void OnMouseDown()
    {
        ObjectToMove.objectToMove = transform;
    }

}
