using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharaterMove : MonoBehaviour
{

    public bool isThereTargetPoint = false;

    public GameObject moveTargetPoint;
    public Camera mainCamera;
    public float maxSpeed;
    public float acceleration; // 가속도
    public float rotationSpeed;

    private float currentSpeed;


    void Start()
    {

    }

    void Update()
    {
        PlayerShipMove();
    }

    void FixedUpdate()
    {
        //MousePingAppoint();
    }


    public void MousePingAppoint()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray raycast;
            RaycastHit raycastHit;

            raycast = mainCamera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(raycast, out raycastHit, Mathf.Infinity))
            {
                Vector3 targetPoint = new Vector3(raycastHit.point.x - transform.position.x, 0f, raycastHit.point.z - transform.position.z);

                Instantiate(moveTargetPoint, targetPoint, Quaternion.identity);

                isThereTargetPoint = true;
            }
        }
    }

    public void PlayerShipMove()
    {
        if (Input.GetMouseButton(0))
        {
            Ray raycast;
            RaycastHit raycastHit;

            raycast = mainCamera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(raycast, out raycastHit, Mathf.Infinity))
            {
                Vector3 directory = new Vector3(raycastHit.point.x - transform.position.x, 0f, raycastHit.point.z - transform.position.z);
                currentSpeed = Mathf.Clamp(currentSpeed += acceleration * Time.deltaTime, 0f, maxSpeed);
                //transform.rotation = Quaternion.LookRotation(directory); // 타겟을 향해 바로 회전
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(directory), Time.deltaTime * rotationSpeed);
            }
        }
        else
        {
            currentSpeed = Mathf.Clamp(currentSpeed -= acceleration * Time.deltaTime, 0f, maxSpeed);
        }

        transform.Translate(Vector3.forward * currentSpeed * Time.deltaTime);
    }
}
