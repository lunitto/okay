using UnityEngine;

public class ObjController : MonoBehaviour
{
    //[SerializeField] GameObject circle;


    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ball"))
        {
            gameObject.SetActive(false);

        }    
    }
}
