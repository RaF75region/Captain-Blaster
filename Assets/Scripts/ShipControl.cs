using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControl : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject bulletprefab;
    public float speed = 10f;
    public float xLimit = 7f;
    public float yLimit = 5f;
    public float reloadTime = 0.5f;
    float elapsedTime = 0f;

    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;

        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");
        transform.Translate(xInput * Time.deltaTime * speed, yInput*speed*Time.deltaTime, 0f);

        Vector3 position = transform.position;
        position.x = Mathf.Clamp(position.x, -xLimit, xLimit);
        position.y = Mathf.Clamp(position.y, -yLimit, yLimit);
        transform.position = position;

        if(Input.GetButtonDown("Jump") && elapsedTime> reloadTime)
        {
            Vector3 spawnPos = transform.position;
            spawnPos += new Vector3(0f, 1.2f, 0);
            Instantiate(bulletprefab, spawnPos, Quaternion.identity);
            elapsedTime = 0f;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameManager.PlayerDied();
    }

}
