using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    public void MainMenu () {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void Quit() {
        Time.timeScale = 1;
        Application.Quit();
    }
    public void Restart()
    {
        Time.timeScale = 1;
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}
