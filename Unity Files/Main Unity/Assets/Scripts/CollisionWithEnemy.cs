using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class CollisionWithEnemy : MonoBehaviour
{
    public GameObject GM;

    void OnCollisionEnter2D(Collision2D collision)    //Collision2D
    {
        if (collision.gameObject.tag == "Enemy")
        {

            //Debug.Log("CollisionWithEnemy");
            GM.GetComponent<GameManager>().activeChangeGameOverForm();
            GM.GetComponent<GameManager>().Pause();

        }
    }
}
