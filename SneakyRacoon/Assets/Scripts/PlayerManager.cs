using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("collision");
        if (collision.gameObject.CompareTag("Food"))
        {
            GameManager.Instance.ResetHunger();
            GameManager.Instance.playerScore++;
            Destroy(collision.gameObject);
        }

        
    }
}
