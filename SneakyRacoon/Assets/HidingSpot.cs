using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidingSpot : MonoBehaviour
{

   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) // if player is under a table
        {
            
            Color tablecolor = gameObject.GetComponent<SpriteRenderer>().color;
            tablecolor.a = 0.7f;
            gameObject.GetComponent<SpriteRenderer>().color = tablecolor; //these lines change the alpha level of the hiding spot when the player is under it 

            GameManager.Instance.PlayerisHidden = true;
        }
        if (collision.gameObject.CompareTag("Food"))
        {
            Destroy(collision.gameObject);
        }




    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Color tablecolor = gameObject.GetComponent<SpriteRenderer>().color;
            tablecolor.a = 1f;
            gameObject.GetComponent<SpriteRenderer>().color = tablecolor; //these lines change the alpha level of the hiding spot when the player has left it 

            GameManager.Instance.PlayerisHidden = false;
        }
    }
}
