using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAttract : MonoBehaviour {

    public GameObject target;
    public List<GameObject> targets;

    void Update()
    {
        if (targets.Count > 0)
        {
            foreach (GameObject target in targets)
            {
                target.transform.position = Vector3.Lerp(target.transform.position, transform.position, Time.deltaTime * 1);
                //if (target.transform.position == transform.position)
                //{
                //    target.transform.position += Vector3.down * Time.deltaTime;
                //    print("TURNON");
                //}
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "FreeCube")
        {
            targets.Add(other.gameObject);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "FreeCube")
        {
            //other.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            targets.Clear();
        }
    }
}
