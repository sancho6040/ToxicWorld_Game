using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowScript : MonoBehaviour
{
    public Transform targetPosition;
    public Transform targetRotation;


    private void Update()
    {
        if(targetPosition)
        {
            transform.position = targetPosition.position;
        }

        if(targetRotation)
        {
            transform.rotation = targetRotation.rotation;
        }
    }
}
