using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class PlayerController : MonoBehaviour
{  public Rigidbody2D rigidbody2d;
   public float speed;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetAxis("Horizontal") > 0) //It Is Positive(+ve)
        {
            rigidbody2d.linearVelocity = new Vector2(speed, 0f);
        }
        else if (Input.GetAxis("Horizontal") < 0) //It Is Negative(-ve)
        {
            rigidbody2d.linearVelocity = new Vector2(-speed, 0f);
        }
        else if (Input.GetAxis("Vertical") > 0) //It Is Positive(+ve)
        {
            rigidbody2d.linearVelocity = new Vector2(0f, speed);
        }
        else if (Input.GetAxis("Vertical") < 0) //It Is Negative(-ve)
        {
            rigidbody2d.linearVelocity = new Vector2(0f, -speed);
        }
        else if (Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0)
                {
             //stop
        }

                   
        

    }
}
