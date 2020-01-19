using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GyroSCR : MonoBehaviour
{
    private bool gyroEnabled;
    private Gyroscope gyro;

    private GameObject cameraContainer;
    private Quaternion rot;
    Text text;
    public GameObject GO;
    void Start()
    {
        cameraContainer = new GameObject("Cam" +
            "public era Container");
        cameraContainer.transform.position = transform.position;
        transform.SetParent(cameraContainer.transform);
        gyroEnabled = EnableGyro();
    }
    private bool EnableGyro()
    {
        if (SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            gyro.enabled = true;

            cameraContainer.transform.rotation = Quaternion.Euler(90f, 90f, 0f);
            rot = new Quaternion(0, 0, 1, 0);


            return true;
        }
        return false;
    }

    // Update is called once per frame
    void Update()
    {
        GO.GetComponent<Text>().text = gyro.attitude.ToString() + "\nROT = " + rot.ToString();
        if (gyroEnabled)
        {
            transform.localRotation = gyro.attitude * rot;
        }
    }
}
