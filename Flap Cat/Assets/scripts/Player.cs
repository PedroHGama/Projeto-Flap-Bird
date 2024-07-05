using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rB;
    public float forcaPulo;
    private GameManager gameManager;
    private AudioSource playerAudio;
    public AudioClip jumpSound;
  
    // Start is called before the first frame update
    void Start()
    {
        rB = GetComponent<Rigidbody2D>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
       if(gameManager.isGameOver == false)
       {   
        Pular();
       }
        
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
       
        if(collision.gameObject.tag == "Sensor"){
            gameManager.pontos++;
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    { 
        if(collision.gameObject.tag == "obstaculo")
        {
            gameManager.isGameOver = true;
        }
    }
   
    public void Pular()
    {

       if(Input.GetKeyDown(KeyCode.Space))
        {
            playerAudio.PlayOneShot(jumpSound);
            rB.velocity = new Vector2(rB.velocity.x, 0);
            rB.AddForce(new UnityEngine.Vector2(0, 380));
        }

    }
}
