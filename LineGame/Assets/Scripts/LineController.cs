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

    //Get Info
    public void GetInfo(float _speed,Transform pos,Color col)
    {
        speed = _speed;
        EndPosition = pos;
        InitialColor = col;
        GetComponent<SpriteRenderer>().color = InitialColor;
    
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


    //Instantiate Object

}
