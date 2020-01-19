using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class EndPoint : MonoBehaviour
{
    public GameObject GM;
    void OnTriggerEnter2D(Collider2D collision)    //Collision2D
    {
        if (collision.gameObject.tag == "End")
        {
            Debug.Log("Collision");

            GM.GetComponent<GameManager>().activeChangeNextLevelForm();
        }
    }
}
