using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    GameManager gameManager;
    public float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.FindObjectOfType<GameManager>();
        Rigidbody2D rigibody = GetComponent<Rigidbody2D>();
        rigibody.velocity = new Vector2(0f, speed);
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        gameManager.AddScore();
        Destroy(gameObject);
    }
}
