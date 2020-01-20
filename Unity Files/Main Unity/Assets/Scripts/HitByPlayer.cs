using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitByPlayer : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rb;
    public Transform player;
    
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {   
        transform.TransformPoint(Vector3.zero);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Sword");
        if(collision.tag == "Sword")
        {
            float x = transform.position.x;
            float y = transform.position.y;

            float triangleX = x - player.position.x;
            float triangleY = y - player.position.y;
            //Vector3 r = transform.- player.position;

            //Rigidbody2D.
            if(gameObject.tag == "Enemy")
            {
                //transform.position += r;
                Debug.Log(transform.TransformPoint(Vector3.zero));
            }
            
            rb.AddForce(new Vector2(triangleX * 10, triangleY * 10), ForceMode2D.Impulse);

        }
    }
}
