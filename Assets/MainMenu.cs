using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenu : MonoBehaviour

{
    public void Playgame()
    {
        SceneManager.LoadScene("game", LoadSceneMode.Additive);
    }
    public void QuitGame()
    {
        Application.Quit(); 
    }
     

} 
