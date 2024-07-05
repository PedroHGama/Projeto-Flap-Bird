using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    private Rigidbody2D obstaculoRb;
    public float speed;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        obstaculoRb = GetComponent<Rigidbody2D>();      
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameManager.isGameOver == false)
        {
            obstaculoRb.velocity = new Vector2(-1 * speed,0);
        }
        else
        {
            obstaculoRb.velocity = Vector2.zero;
        }
       

        if(transform.position.x <= -12)
        {
            Destroy(gameObject);
        }
    }
}
