using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astroid : MonoBehaviour
{
    void Update()
    {
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -29.4f, 29.4f), Mathf.Clamp(transform.position.y, -51.9f, 51.9f));
    }
}
