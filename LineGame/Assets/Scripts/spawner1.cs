using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner1 : MonoBehaviour
{
    public GameObject Splash1;
    public float direction;


    void SpawnerSplash()
    {
      GameObject splach=  Instantiate(Splash1, transform.position, transform.rotation);
        splach.GetComponent<SplashLeft>().direction = direction;
        
    }


    private void OnMouseUp()
    {
        SpawnerSplash();
    }
}
