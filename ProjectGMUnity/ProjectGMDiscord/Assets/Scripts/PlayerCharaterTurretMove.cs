using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharaterTurretMove : MonoBehaviour
{
    public GameObject mainTurret;

    //적 오브젝트 오직 실험용
    public GameObject enemyObject;

    public Transform enemyTarget;
    

    void Start()
    {
        
    }

    void Update()
    {
        TurretRotation();
    }

    public void TurretRotation()
    {
        //Vector3 enemyPosition = new Vector3(enemyObject.transform.position.x - transform.position.x, 0f, enemyObject.transform.position.z - transform.position.z);


        //Quaternion turretRotation = Quaternion.LookRotation(enemyPosition);
        //transform.rotation = turretRotation;

        enemyTarget = GameObject.FindWithTag("Enemy").transform;

        Vector3 enemyPosition = new Vector3(enemyTarget.transform.position.x - transform.position.x, 0f, enemyTarget.transform.position.z - transform.position.z);

        Quaternion turretRotation = Quaternion.LookRotation(enemyPosition);
        transform.rotation = turretRotation;

    }
}
