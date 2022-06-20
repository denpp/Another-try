using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenu : MonoBehaviour

{
    public void Playgame()
    {
        SceneManager.LoadScene("game");
    }
    public void QuitGame()
    {
        Application.Quit(); 
        Debug.Log("Game Closed");
    }
     

} 
