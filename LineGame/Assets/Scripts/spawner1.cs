using UnityEngine;

public class spawner1 : MonoBehaviour
{
    public GameObject Splash1;
    public GameObject spawner;
    public float direction;
    public Sprite yadhreb;
    public Sprite rest;







    void SpawnerSplash()
    {
      GameObject splach=  Instantiate(Splash1, transform.position, transform.rotation);
        splach.GetComponent<SplashLeft>().direction = direction;
        
    }


    private void OnMouseUp()
    {
        SpawnerSplash();
        AudioManager.playSound("ClickButton");
        
        spawner.gameObject.GetComponent<SpriteRenderer>().sprite = rest;
        

    }
    private void OnMouseDown()
    {
        spawner.gameObject.GetComponent<SpriteRenderer>().sprite = yadhreb ;

    }









}
