using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)    //Collision2D
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("You die!");

        }
    }
}
