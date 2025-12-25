using System;
using UnityEngine;

using UnityEngine;

public class FollowAgent : MonoBehaviour
{
    [SerializeField] private GameObject agent;
    private Vector3 _offset;
    private void Start()
    {
        _offset = transform.position;
    }
    private void LateUpdate()
    {
        transform.position = new Vector3(
            agent.transform.position.x
            , agent.transform.position.y -1 
            , agent.transform.position.z) + _offset;
    }
}
