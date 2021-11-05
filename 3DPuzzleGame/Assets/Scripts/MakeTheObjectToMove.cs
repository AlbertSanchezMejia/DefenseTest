using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeTheObjectToMove : MonoBehaviour
{
    ObjectToMove moveThisObject;

    void Start()
    {
        moveThisObject = FindObjectOfType<ObjectToMove>();
    }

    void OnMouseDown()
    {
        moveThisObject.SetTheObjectsMove(transform);
    }

}
