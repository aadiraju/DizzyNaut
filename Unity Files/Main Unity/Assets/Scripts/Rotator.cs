using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    //[SerializeField]
    private float rotSpeed;
    bool Boolean;
    int direction;


    private void Start()
    {
        Boolean = (Random.value > 0.5f);
        direction = Boolean ? 1 : -1;
        rotSpeed = Random.Range(0.05f, 1.0f) * direction;
    }
    void FixedUpdate()
    {
        transform.Rotate (new Vector3(0f, 0f, rotSpeed));
    }
}
