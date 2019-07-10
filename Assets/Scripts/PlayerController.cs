using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Text scoreText;
    public Text countText;
    public Text winText;
    public Text lifeText;
    public Text gameOverText;
    private int count;
    private int score;
    private int life;
    private Rigidbody rb;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetAllText ();
        score = 0;
        winText.text = "";
        life = 3;
        gameOverText.text = "";
    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");
    
        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        rb.AddForce (movement * speed);

          if (Input.GetKey("escape"))
         Application.Quit();
    }
    void OnTriggerEnter(Collider other)
    {
         if (other.gameObject.CompareTag("Pick Up"))
         {
             other.gameObject.SetActive (false);
             score = score + 1;
             count = count + 1;
             SetAllText ();

         }

         if (other.gameObject.CompareTag("Enemy Block"))
         {
             other.gameObject.SetActive (false);
             score = score - 1;
             count = count + 1;
             life = life - 1;
             SetAllText ();
             DestroyGameObject();
         }

         if (score == 10)
         {
            transform.position = new Vector3(-10.9f, transform.position.y,-32.3f); }
         }


    void SetAllText ()
    {
         countText.text = "Total: " + count.ToString ();
         scoreText.text = "Score: " + score.ToString ();
         lifeText.text = "Lives: " + life.ToString ();
        if (score >= 30)
        {
        winText.text = "You Win!!!";
        Destroy(rb);
    }
    }

    void DestroyGameObject()
    { if (life == 0)
        {
        Destroy(gameObject); 
        gameOverText.text = "Game Over!";
        }
    }

}