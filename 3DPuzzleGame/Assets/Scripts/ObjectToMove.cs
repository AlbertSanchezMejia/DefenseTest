using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectToMove : MonoBehaviour
{
    Transform objectToMove;
    GameObject markToMove;
    bool havePressShoot;

    void Start()
    {
        markToMove = GameObject.Find("Mark");
    }
    
    public void SetTheObjectsMove(Transform objectTransform)
    {
        if (havePressShoot == false)
        {
            objectToMove = objectTransform;
            markToMove.transform.position = objectTransform.position;
        }
    }

    public void moveTheObjects(Vector3 moveToPosition)
    {
        if (havePressShoot == false && objectToMove != null)
        {
            markToMove.transform.position = moveToPosition;
            objectToMove.position = moveToPosition;
        }
    }

    public void havePressShootButton()
    {
        havePressShoot = true;
        markToMove.SetActive(false);
    }

}