using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject gameObjectToFollow;
    // Parents position should be the same as target object position

    void LateUpdate()
    {
        transform.position = gameObjectToFollow.transform.position + new Vector3 (0,0,-10);
    }
}
