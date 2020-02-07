using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashLeft : MonoBehaviour
{
    public float speedSplash = 0.1f;
    public Rigidbody2D rb;
    private bool isTrig = false;
    public int index;
    public float direction;


    public void Update()
    {
        if (!isTrig)
        {
            rb.MovePosition(rb.position + Vector2.right * speedSplash *direction* Time.deltaTime);

        }

    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag=="Line")
        {
            isTrig = true;

           
        }
    }
}
