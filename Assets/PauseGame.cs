using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public GameObject pauseMenu;
   
    public bool isPaused;

  
  
  
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetButtonDown("Escape"))
        {
            if(isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseTheGame();

            }
        }
        
    
    }


    public void PauseTheGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
        public void QuitGame()
    {
        Application.Quit(); 
        Debug.Log("Game Closed");
    }


    

}
