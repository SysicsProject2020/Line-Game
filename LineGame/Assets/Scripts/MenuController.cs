using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MenuController : MonoBehaviour

{
    public GameObject PanelSetting;
    public GameObject PanelChallenge;
    int mode = 0;
    // Start is called before the first frame update
    public void startGame()
    {
        SceneManager.LoadScene(mode+1);

    }
    public void BackMenu()
    {
        PanelSetting.SetActive(false);
        PanelChallenge.SetActive(false);


    }
    public void Setting()
    {
        if(PanelSetting!=null)
        {
            PanelSetting.SetActive(true);
        }

    }
   

    public void OndropChangevalue(Dropdown change)
    {
        mode = change.value;

    }
}
