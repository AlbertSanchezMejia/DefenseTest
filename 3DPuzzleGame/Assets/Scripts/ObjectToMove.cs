using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectToMove : MonoBehaviour
{
    public static Transform objectToMove;
    public static Transform markToMove;

    void Start()
    {
        objectToMove = null;
        markToMove = GameObject.Find("Mark").transform;
    }

}