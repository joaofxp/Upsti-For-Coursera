using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teste : MonoBehaviour {

    public GameObject platform;

    public GameObject[] myWaypoints;

    [Range(0.0f, 10.0f)]
    public float moveSpeed = 5f;

    public bool loop = true;

    Transform _transform;
    void Start()
    {
        _transform = platform.transform;
    }

    void Update()
    {
        if (loop)
        {
            _transform.position = Vector3.MoveTowards(_transform.position, myWaypoints[1].transform.position, moveSpeed * Time.deltaTime);
        } else
        {
            _transform.position = Vector3.MoveTowards(_transform.position, myWaypoints[0].transform.position, moveSpeed * Time.deltaTime);
        }
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            loop = !loop;
        }
    }
}

