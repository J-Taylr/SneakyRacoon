using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidingSpot : MonoBehaviour
{

   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) // if player is under a table
        {
            print("collidah");
            Color tablecolor = gameObject.GetComponent<SpriteRenderer>().color;
            tablecolor.a = 0.5f;
            gameObject.GetComponent<SpriteRenderer>().color = tablecolor; //these lines change the alpha level of the table when the player is under it 

            GameManager.Instance.PlayerisHidden = true;
        }
    }

    public void HideOn()
    {
        
         
        Color tablecolor = gameObject.GetComponent<SpriteRenderer>().color;
        tablecolor.a = 0.5f;
        gameObject.GetComponent<SpriteRenderer>().color = tablecolor; //these lines change the alpha level of the table when the player is under it
    }

}
