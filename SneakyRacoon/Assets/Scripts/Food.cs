using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    PlayerManager player;
    UIPopup Pop;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerManager>();
        Pop = GameObject.FindGameObjectWithTag("Call").GetComponent<UIPopup>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Player")
        {
            collision.GetComponent<MouseMovement>().score++;
            GameManager.Instance.ResetHunger();
            GameManager.Instance.foodSpawned.Remove(this.gameObject);
            player.EatFood();           
            Destroy(gameObject);
            print("Howdy");
            Pop.StartChat();
        }

        if (collision.gameObject.CompareTag("Food")) //stops from spawning on another food object
        {
            GameManager.Instance.foodSpawned.Remove(this.gameObject);
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Wall")) //stops from spawning in wall
        {
            GameManager.Instance.foodSpawned.Remove(this.gameObject);
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Hiding")) //stops from spawning in hiding spots
        {
            GameManager.Instance.foodSpawned.Remove(this.gameObject);
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Prop")) //stops from spawning in on props with colliders
        {
            GameManager.Instance.foodSpawned.Remove(this.gameObject);
            Destroy(gameObject);
        }
    }
}
