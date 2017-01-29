using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    Transform _transform;
    Vector3 targetPosition;
    public float speed = 1.5f;

    bool CanMove;

    void Awake()
    {
        _transform = GetComponent<Transform>();
        targetPosition = _transform.position;
        CanMove = true;
    }

    void Update()
    {
        if (!CanMove)
            return;

        if (_transform.position.y < -.5f)
            CanMove = false;

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100, 1 << 8))
            {
                targetPosition = hit.point;
            }
        }
        _transform.transform.position = Vector3.Lerp(_transform.transform.position, targetPosition, Time.deltaTime * speed);
        if (GetComponent<Rigidbody>().velocity.sqrMagnitude > 0.5f)
        {
            GetComponent<Rigidbody>().velocity *= 0.1f;
        }
    }
}
