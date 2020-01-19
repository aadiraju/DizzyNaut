using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityAffectedObject : MonoBehaviour
{
    Rigidbody2D rb;
    float dirX, dirY;

    [SerializeField]
    float weight = 5f;

    [SerializeField]
    float moveSpeed = 100f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.acceleration.x * moveSpeed;
        dirY = Input.acceleration.y * moveSpeed;
        //transform.position = new Vector2(Mathf.Clamp(transform.position.x, -29.4f, 29.4f), Mathf.Clamp(transform.position.y, -51.9f, 51.9f));
    }

    void FixedUpdate()
    {
            rb.velocity = new Vector2(dirX * (1/weight), dirY * (1/weight));
    }
}
