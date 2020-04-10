using UnityEngine;


public class LineController : MonoBehaviour
{
    //Variable
    float speed;
    Transform EndPosition;
    public Rigidbody2D rb;
    public GameObject particleeffect;
    public Material[] mat;
    public Renderer rend;
    int indexcolor;
   


    //Get Info

    public void GetInfo(float _speed,Transform pos,Material mat,int index)
    {
        speed = _speed;
        EndPosition = pos;
     
        
        rend.sharedMaterial = mat;
        indexcolor = index;
     


        Move();
    }


    //Move Method
    void Move()
    {

        

       
        LeanTween.moveY(gameObject, EndPosition.position.y, speed);
        
         rb.transform.localScale = new Vector3(2.5f, Random.Range(5f, 20f),2.5f ) ;

    }

    // CollisionMethod

    public void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.tag == "Splash"  )
        {
          
            int _index = hit.transform.GetComponent<SplashLeft>().index;
            Color c = hit.GetComponent<SpriteRenderer>().color;
            Vector3 placement = hit.transform.position;
            Destroy(hit.gameObject);

            if (indexcolor==_index)
            {
                GameObject effect = Instantiate(particleeffect, placement, Quaternion.identity);

                effect.GetComponent<ParticleSystem>().startColor = c;
                GetComponent<SpriteRenderer>().enabled = false;
                Destroy(effect, 0.5f);
                Destroy(gameObject);
                switch (indexcolor)
                {
                    case 0:
                      
                        rend.sharedMaterial = mat[0];
                        rb.drag = -2;
                        ScoreCounter.instance.PlayerScoreAdd();
                        break;
                    case 1:
                        
                        rend.sharedMaterial = mat[0];

                        rb.drag = -2;
                        ScoreCounter.instance.PlayerScoreAdd();
                        break;
                    default:
                        break;
                }
               
            }
            else
            { Debug.Log("you loose"); 
      

            }

        }
       

    }

   

}
