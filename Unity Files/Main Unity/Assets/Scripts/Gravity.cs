using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{

    [SerializeField]
    private float gravityX = 0f;
    [SerializeField]
    private float gravityY = -9.8f;

    void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;//or right for right landscape }
    }

        void FixedUpdate()
    {
        Physics2D.gravity = new Vector2(gravityX, gravityY);
    }
}
