using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    float deltaX, deltaY;
    Rigidbody2D rb;
    Vector2 direcMove;
    Vector2 touchPos;
    

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        Touch touch = Input.GetTouch(0);
        touchPos = Camera.main.ScreenToWorldPoint(touch.position);
        transform.position = new Vector3(touchPos.x, touchPos.y, 0);
    }
    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            touchPos = Camera.main.ScreenToWorldPoint(touch.position);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    //deltaX = touchPos.x - transform.position.x;
                    //deltaY = touchPos.y - transform.position.y;
                    rb.rotation = 0;
                    transform.position = new Vector3(touchPos.x, touchPos.y, 0);
                    rb.velocity = Vector2.zero;
                    deltaX = 0;//touchPos.x - transform.position.x;
                    deltaY = 0;//touchPos.y - transform.position.y;
                    break;

                case TouchPhase.Moved:
                    //deltaX = (touchPos.x - transform.position.x);
                    //deltaY = (touchPos.y - transform.position.y);
                    //rb.velocity = Vector2.zero;
                    //rb.MovePosition(new Vector2(touchPos.x - deltaX, touchPos.y - deltaY));
                    //direcMove = new Vector2(deltaX, deltaY);
                    break;

                case TouchPhase.Ended:
                    deltaX = (touchPos.x - transform.position.x);
                    deltaY = (touchPos.y - transform.position.y);
                    rb.velocity = Vector2.zero;
                    //rb.MovePosition(new Vector2(touchPos.x - deltaX, touchPos.y - deltaY));
                    direcMove = new Vector2(deltaX, deltaY);
                    rb.velocity = direcMove;
                    //deltaX = 0;
                    //deltaY = 0;
                    break;
            }


        }
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("ball");
    }    
}
