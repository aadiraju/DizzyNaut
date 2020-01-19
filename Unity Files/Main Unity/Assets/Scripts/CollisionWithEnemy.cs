using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CollisionWithEnemy : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)    //Collision2D
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("CollisionWithEnemy");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
