using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowFroglet : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] Vector3 offset; 

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.position + offset; 
    }
}
