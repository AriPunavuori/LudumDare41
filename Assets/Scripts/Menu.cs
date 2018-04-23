using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    public GameObject MM;
   



    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.E))
        {
            print("pöö");
            GamePause();
          
        }
    }



    public void PlayGame()
    {         
        SceneManager.LoadScene("DevScene");
        print(Time.timeScale);
        MenuOff();
    }

   public void GamePause()
    {
        
            Time.timeScale = 0;
            print("Tauko peliin!");
            
            SceneManager.LoadScene("MenuScene");
        
    }

        void MenuOff()
    {
        MM.SetActive(false);
        print("Peli alkaa");
    }

      
    

    public void Quit()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
       
    }


}
