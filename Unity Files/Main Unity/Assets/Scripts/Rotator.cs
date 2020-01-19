using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    //[SerializeField]
    private float rotSpeed;

    private void Start()
    {
        rotSpeed = Random.Range(0.05f, 1.0f);
    }
    void FixedUpdate()
    {
        transform.Rotate (new Vector3(0f, 0f, rotSpeed));
    }
}
