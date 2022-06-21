using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gameoverscript : MonoBehaviour
{
    public Health health;
    public GameObject gameOverMenu;
    public GameObject playertjuh;


    
    // Start is called before the first frame update
    void Start()
    {
        gameOverMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(health.currentHealth == 0) 
        {
         gameOverMenu.SetActive(true);
         Time.timeScale = 0f;
         
        }
        if(playertjuh.transform.position.y < -3){

        gameOverMenu.SetActive(true);
        Time.timeScale = 0f;
        }
            

    }

    
           
     
    



}
