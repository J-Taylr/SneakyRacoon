using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D player) {
        if (player.tag == "Player")
        {
            print("Howdy");
            player.GetComponent<MouseMovement>().score++;
            GameManager.Instance.ResetHunger();
            Destroy(gameObject);
        }
    }
}
