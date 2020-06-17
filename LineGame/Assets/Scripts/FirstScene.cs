using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstScene : MonoBehaviour
{
    public float timeScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeScene += Time.deltaTime;
        if (timeScene >= 0.5f)
        {
            GetComponent<Animation>().Play("SceneAnimation");
            SceneManager.LoadScene(0);
            
        }
    }
}
