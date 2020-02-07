using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineController : MonoBehaviour
{
    //Variable
    float speed;
    Transform EndPosition;
    public Rigidbody2D rb;
    Color InitialColor;
    

    public Material[] mat;
    public Renderer rend;
    int indexcolor;
    bool isColored;


    //Get Info

    public void Start()
    {
        //rend = GetComponent<Renderer>();
       // rend.enabled = true;
      
    }

    private void Update()
    {
        
    }
    public void GetInfo(float _speed,Transform pos,Material mat,int index)
    {
        speed = _speed;
        EndPosition = pos;
        //InitialColor = col;
        //GetComponent<SpriteRenderer>().color = InitialColor;
        rend.sharedMaterial = mat;
        indexcolor = index;
        Move();
    }
    //Move Method
    void Move()
    {
        //rb.MovePosition(EndPosition.position*speed);
        rb.drag = speed;
        rb.velocity = (transform.position - EndPosition.position)*Time.deltaTime;
    }
    // CollisionMethod

  public void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.tag == "Splash"  )
        {

            int _index = hit.transform.GetComponent<SplashLeft>().index;
            Destroy(hit.gameObject);
            if (indexcolor==_index)
            {
                Destroy(gameObject, 0.2f);
                switch (indexcolor)
                {
                    case 0:
                        //rend.material.SetColor("_BaseColor", Color.white);
                        rend.sharedMaterial = mat[0];
                        rb.drag = -2;
                        break;
                    case 1:
                        //rend.material.SetColor("_BaseColor", Color.white);
                        rend.sharedMaterial = mat[0];

                        rb.drag = -2;
                        break;
                    default:
                        break;
                }
                //rend.material.color = new Color(rend.material.color.r, rend.material.color.b, rend.material.color.g, 0);
            }
            else
            { Debug.Log("you loose"); 
      

            }

        }
       

    }

    //Instantiate Object

}
