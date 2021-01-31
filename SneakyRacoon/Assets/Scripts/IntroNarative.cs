using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class IntroNarative : MonoBehaviour
{
    public int slide = 1;
    public Text T;
    public GameObject Cam1;
    public GameObject Cam2;
    public GameObject Cam3;
    public GameObject Cam4;
    public Animator Player;
    // Start is called before the first frame update
    void Start()
    {
        T.text = "It was a dark and quiet night, the moonlight shone down on Albert as he surveyed the house around him.";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) & slide == 1)
        {
            slide = 2;
            Cam1.SetActive(false);
            Cam2.SetActive(true);
            T.text = "It was a place of great danger...";
            Player.enabled = false;
        }else
        if (Input.GetKeyDown(KeyCode.Space) & slide == 2)
        {
            slide = 3;
            Cam2.SetActive(false);
            Cam3.SetActive(true);
            T.text = "But also a place of great reward.";
        }else
        if (Input.GetKeyDown(KeyCode.Space) & slide == 3)
        {
            slide = 4;
            Cam3.SetActive(false);
            Cam1.SetActive(true);
            T.text = "If he could succeed in getting through the house undetected…";
        }else
        if (Input.GetKeyDown(KeyCode.Space) & slide == 4)
        {
            slide = 5;
            Cam1.SetActive(false);
            Cam4.SetActive(true);
            T.text = "Then he would be able to have the biggest feast imaginable.";
        }else
        if (Input.GetKeyDown(KeyCode.Space) & slide == 5)
        {
            slide = 6;
            SceneManager.LoadScene("SampleScene");
        }
    }
    
}
