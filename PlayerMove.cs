using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayerMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public Text text;

    float HorizontalMove; 
    float speed = 7f; //snelheid van de player
    float jump = 10f; //hoe hoog je springt
    

    public LayerMask groundLayer;
       
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        
        rb.freezeRotation = true; //zorgt ervoor dat de karakter stop met draaien
    }

    // Update is called once per frame
    void Update()
    {
        
        float xPos = Input.GetAxisRaw("Horizontal"); //als je d indrukt dan word het getal 1 als je a indrukt word het -1

        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 1.15f); //zorgt ervoor dat de player kan bewegen
        
       if (hit.collider != null) //als er geen grond onder de player is kan de player springen
       {
            if (Input.GetButtonDown("Jump")) //als je bijv spatie indrukt dan spring je
            {
               rb.AddForce(new Vector2(0, 50 * jump)); //zorgt ervoor dat je springt
            }
       }
        
        rb.velocity = new Vector2(xPos * speed, rb.velocity.y); 

        if (transform.position.y < -30) //als playerY onder de 30 zit dan ga je naar de GameOver screen
        {
            SceneManager.LoadScene("GameOver"); //zorgt ervoor dat de player naar de Gameoverscreen gaat
           
        }
    }


}
