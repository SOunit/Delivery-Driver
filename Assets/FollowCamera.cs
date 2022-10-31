using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField]
    GameObject thingToFollow;

    // camera should be in the same position with car
    void LateUpdate()
    {
        transform.position =
            thingToFollow.transform.position + new Vector3(0, 0, -10);
    }
}
