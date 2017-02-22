using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "Player":
                GameController.singleton.PlayerLose();
                break;
            case "FreeCube":
                GameController.singleton.PlayerWin();
                break;
            default:
                break;
        }
    }
}
