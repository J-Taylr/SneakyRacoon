using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{

    public float speed;
    public float rotationOffset;
    public int score;
    public float scoref;

    public GameObject DeathUI;
    public bool dead;

    private Vector3 target; //mouse position

    private Rigidbody2D rb2D;


    public GameObject pauseMenu;
    public bool paused;
  
    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        Time.timeScale = 1;
        dead = false;
    }

  
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused)
            {
                UnPause();
            }
            else
            {
                Pause();
            }
        }

        if (dead)
        {
            DeathUI.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {        
            if (Input.GetMouseButton(0))
            {
                MovePlayer();
            }
            scoref = (float)score;
            rb2D.drag = 1 - scoref/ 20;
            RotatePlayer();
        }
    }

    public void Pause() {
        paused = true;
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }
    public void UnPause() {
        paused = false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }


    public void MovePlayer()
    {
        rb2D.AddForce(transform.up * speed);
        target = Input.mousePosition;
        target.z = 20;
        //transform.position = Vector2.Lerp(transform.position, Camera.main.ScreenToWorldPoint(target), speed * Time.deltaTime);
    }

    public void LowerSpeed()
    {
        print("speed check");
        if (speed > 1f)
        {
            speed = speed - .5f;
        }
        else if (speed > 0.1f)
        {
            speed = speed - 0.1f;
        }


    }

    public void RotatePlayer()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 0;

        Vector3 objectPos = Camera.main.WorldToScreenPoint(transform.position);
        mousePos.x = mousePos.x - objectPos.x;
        mousePos.y = mousePos.y - objectPos.y;

        float angle = (Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg) - 90;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

    }


}
