using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour {
    public GameObject MM;
    public GameObject ds;
    public GameObject OptionsImage;
    //public GameObject PlayersImage;
    public GameObject ControlsImage;



    public void PlayGame()
    {         
        SceneManager.LoadScene("DevScene");

        print(Time.timeScale);
        MenuOff();
    }



        void MenuOff()
        {
            
            MM.SetActive(false);
            print("Peli alkaa");
        }

    void OptionsMenu()
    {
        
        MM.SetActive(false);
        ds.SetActive(true);
    }

    public void BackMenu()
    {
        MM.SetActive(true);
        OptionsImage.SetActive(true);
        //PlayersImage.SetActive(false);
        ControlsImage.SetActive(true);

    }
      
   //public void Players()
   // {
   //     OptionsImage.SetActive(false);
   //     PlayersImage.SetActive(true);
   //     ControlsImage.SetActive(false);
   // }

    public void Controls()
    {
        OptionsImage.SetActive(false);
        ControlsImage.SetActive(true);
       // PlayersImage.SetActive(false);
    }

    public void Quit()
    {
        
            Application.Quit();
  
       
    }




}
