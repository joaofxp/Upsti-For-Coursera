using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "Player":
                GameManager.singleton.PlayerLose();
                break;
            case "FreeCube":
                GameManager.singleton.PlayerWin();
                break;
            default:
                break;
        }
    }
}
