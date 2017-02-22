using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    Transform _transform;
    Rigidbody _rigidbody;
    Vector3 targetPosition;
    public float speed = 1.5f;

    bool CanMove;

    void Awake()
    {
        _transform = GetComponent<Transform>();
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.useGravity = false;
    }

    void Start()
    {
        targetPosition = _transform.position;
        CanMove = true;
    }

    void FixedUpdate()
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

        //_transform.position = _transform.transform.position + targetPosition * Time.deltaTime * speed;

        //TODO: Checar como mover de um ponto ao outro no script do unity

        Vector3 direction = (targetPosition - _transform.transform.position).normalized;
        _rigidbody.MovePosition(transform.position + direction * speed * Time.deltaTime);

        if (!Physics.Raycast(transform.position, Vector3.down,100f))
        {
            _rigidbody.useGravity = true;
            print("FALL");
        } else if (_rigidbody.useGravity == true && Physics.Raycast(transform.position, Vector3.down))
        {
            _rigidbody.useGravity = false;
            print("STOP");
        }
        //_transform.transform.position = Vector3.Lerp(_transform.transform.position, targetPosition, Time.deltaTime * speed);

        //if (GetComponent<Rigidbody>().velocity.sqrMagnitude > 0.5f)
        //{
        //    GetComponent<Rigidbody>().velocity *= 0.1f;
        //}
    }
}
