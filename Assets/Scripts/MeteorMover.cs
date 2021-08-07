using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorMover : MonoBehaviour
{
    public float speed = -2f;
    Rigidbody2D rigibody;
    // Start is called before the first frame update
    void Start()
    {
        rigibody = GetComponent<Rigidbody2D>();
        rigibody.velocity = new Vector2(0, speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
