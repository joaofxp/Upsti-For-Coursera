using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAttract : MonoBehaviour {

    public static CubeAttract singleton;

    public GameObject target;
    public bool CanWin;
    public List<GameObject> targets;

    void Awake()
    {
        CanWin = false;
        if (singleton == null)
        {
            singleton = this;
        }
        else if (singleton != this)
        {
            Destroy(gameObject);
        }
    }

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
            StartCoroutine(Winable(1));
        }
    }

    IEnumerator Winable(float duration)
    {
        CanWin = true;
        yield return new WaitForSeconds(duration);
        CanWin = false;
    }
}