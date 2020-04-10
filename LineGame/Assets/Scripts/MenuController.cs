using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour

{
    public GameObject PanelSetting;
    public GameObject PanelChallenge;
    // Start is called before the first frame update
    public void startGame()
    {
        SceneManager.LoadScene(2);

    }
    public void BackMenu()
    {
        SceneManager.LoadScene(1);

    }
    public void Setting()
    {
        if(PanelSetting!=null)
        {
            PanelSetting.SetActive(true);
        }

    }
    public void Challenge()
    {
        if (PanelChallenge != null)
        {
            PanelChallenge.SetActive(true);
        }

    }
    public void RainBow()
    {
        SceneManager.LoadScene(3);

    }
    public void Timer()
    {
        SceneManager.LoadScene(4);

    }
    public void Speed()
    {
        SceneManager.LoadScene(5);

    }


}
