using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LevelDegree : MonoBehaviour
{
    public  int BuildIndex;
    public GameObject PanelLevel; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    public void NextLevelButtonTimer()
    {
        if (PanelLevel != null)
        {
            SceneManager.LoadScene(BuildIndex);
            AudioManager.playSound("ClickButton");
        }
    }
}
