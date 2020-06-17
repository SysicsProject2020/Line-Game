using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{ 
    public GameObject PanelSetting;
    public GameObject PanelShop;
    public GameObject PanelPause;
    public GameObject PanelGameOver;
    int mode = 0;
    



    public void StartGame()
    {
        SceneManager.LoadScene(mode+1);
        AudioManager.playSound("ClickButton");

    }
    public void BackMenu()
    {
        PanelSetting.SetActive(false);
        AudioManager.playSound("ClickButton");



    }
    public void Setting()
    {
        if(PanelSetting!=null)
        {
            PanelSetting.SetActive(true);
            AudioManager.playSound("ClickButton"); 
            GetComponent<Animation>().Play("PanelSetting");
        }

    }
    public void Shop()
    {
        if (PanelShop != null)
        {
            PanelShop.SetActive(true);
            AudioManager.playSound("ClickButton");
            GetComponent<Animation>().Play("PanelSetting");

        }

    }


    public void OndropChangevalue(Dropdown change)
    {
        mode = change.value;

    }
    public void BackScene()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
        AudioManager.playSound("ClickButton");

    }
    public void RainbowGame()
    {
        SceneManager.LoadScene(2);
        AudioManager.playSound("ClickButton");

    }
   
    public void TimerGame()
    {
        SceneManager.LoadScene(3);
        AudioManager.playSound("ClickButton");
        GetComponent<Animation>().Play("CliqueAnimation");

    }
    public void SpeedGame()
    {
        SceneManager.LoadScene(4);
        AudioManager.playSound("ClickButton");

    }


    
    public void ExitButton()
    {
        Application.Quit();
      AudioManager.playSound("ClickButton");
    }
    public void Pause()
    {
        if (PanelPause != null)
        {
            Time.timeScale = 0f;
            
            PanelPause.SetActive(true);
            AudioManager.playSound("ClickButton");
            GetComponent<Animation>().Play("PanelSetting");


        }


        
    }
    public void BackMenuFromPause()
    {
        PanelPause.SetActive(false);
        Time.timeScale = 1f;
        AudioManager.playSound("ClickButton");




    }

    public void BackMenuFromGameOver()
    {
        PanelGameOver.SetActive(false);
        Time.timeScale = 1f;
        AudioManager.playSound("ClickButton");



    }


}
