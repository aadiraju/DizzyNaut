using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPoint : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)    //Collision2D
    {
        if (collision.gameObject.tag == "End")
        {
            Debug.Log("Collision");
        }
    }
}
