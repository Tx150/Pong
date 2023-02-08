using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausemenu : MonoBehaviour
{
    [SerializeField]
    private GameObject pauseMenu;
    public string sceneName;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pauseMenu.activeSelf == false)
            {
                PauseGame();
            }
            else if (pauseMenu.activeSelf == true)
            {
                ResumeGame();
            }
        }
    }

    public void PauseGame()
    {
    Time.timeScale = 0f;
        pauseMenu.SetActive(true);
    }

    public void ResumeGame()
    {
    Time.timescale = 0.1f;
        pauseMenu.SetActive(false);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(sceneName);
    }
}
