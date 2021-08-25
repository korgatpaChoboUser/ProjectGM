using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShipCameraMove : MonoBehaviour
{
    public float rotationSpeed = 100;

    float mouseX;
    float mouseY;

    void Update()
    {
        PlayerCamera();
    }

    public void PlayerCamera()
    {
        float horizontal = Input.GetAxis("Mouse X");
        float vertical = Input.GetAxis("Mouse Y");

        mouseX += horizontal * rotationSpeed * Time.deltaTime;
        mouseY += vertical * rotationSpeed * Time.deltaTime;

        mouseY = Mathf.Clamp(mouseY, -90, 90);

        transform.eulerAngles = new Vector3(-mouseY, mouseX, 0);
    }
}
