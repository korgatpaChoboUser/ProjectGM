using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharaterTurretMove : MonoBehaviour
{
    public GameObject mainTurret;

    //�� ������Ʈ ���� �����
    public GameObject enemyObject;

    void Update()
    {
        TurretRotation();
    }

    public void TurretRotation()
    {
        Vector3 enemyPosition = new Vector3(enemyObject.transform.position.x - transform.position.x, 0f, enemyObject.transform.position.z - transform.position.z);

        Quaternion turretRotation = Quaternion.LookRotation(enemyPosition);
        transform.rotation = turretRotation;
    }
}
