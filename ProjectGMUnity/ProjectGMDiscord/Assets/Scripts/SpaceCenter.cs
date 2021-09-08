using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceCenter : MonoBehaviour
{
    public GameObject SpaceCenterUp;
    public GameObject SpaceCenterDown;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        SpaceCenterRotation();
    }


    void SpaceCenterRotation()
    {
        SpaceCenterDown.transform.rotation
    }
}
