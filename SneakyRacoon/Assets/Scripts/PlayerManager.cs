using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
   
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("collision");
        if (collision.gameObject.CompareTag("Food")) // if player collides with food
        {
            GameManager.Instance.ResetHunger();
            GameManager.Instance.playerScore++;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Hiding")) // if player is under a table
        {
            Color tablecolor = collision.gameObject.GetComponent<SpriteRenderer>().color;
            tablecolor.a = 0.5f;
            collision.gameObject.GetComponent<SpriteRenderer>().color = tablecolor; //these lines change the alpha level of the table when the player is under it 

            GameManager.Instance.PlayerisHidden = true;
        }

        
    }



    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Hiding")) // if player leaves table
        {
            Color tablecolor = collision.gameObject.GetComponent<SpriteRenderer>().color;
            tablecolor.a = 1;
            collision.gameObject.GetComponent<SpriteRenderer>().color = tablecolor; // change the alpha back to 100 when the player leaves


            GameManager.Instance.PlayerisHidden = false;

        }
    }
}
