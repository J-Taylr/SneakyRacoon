using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiMurder : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D kill) {
        if (kill.tag == "Player")
        {
            kill.GetComponent<MouseMovement>().dead = true;
            GameOver();
        }
    }

    void GameOver() {
        print("You Suck");
    }
}
