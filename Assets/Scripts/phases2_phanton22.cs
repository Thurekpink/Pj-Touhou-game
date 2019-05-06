using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class phases2_phanton22 : MonoBehaviour
{

    GameObject PlayerObject;
    EnemyHealth EplayerHealth;
    GameObject EShots2;
    GameObject sp1;
    GameObject sp2;

    EnemyMoveTest Emt;

    void Awake()
    {
        PlayerObject = GameObject.FindGameObjectWithTag("Enemy");
        EplayerHealth = PlayerObject.GetComponent<EnemyHealth>();

        Emt = gameObject.GetComponent<EnemyMoveTest>();
        EShots2 = GameObject.FindGameObjectWithTag("EnemyBulletSpawnph2");
        sp1 = GameObject.FindGameObjectWithTag("sph21");
        sp2 = GameObject.FindGameObjectWithTag("sph22");

        Emt.GetComponent<EnemyMoveTest>().Speed = 1;
        EShots2.SetActive(false);

    }

    void Update()
    {

        if (EplayerHealth.currentHealth == 400)
        {
            EShots2.SetActive(true);
            sp1.GetComponent<Transform>().SetPositionAndRotation(new Vector3(5.27f, 0, 3.88f), new Quaternion(0, 0, 0, 0));
            sp2.GetComponent<Transform>().SetPositionAndRotation(new Vector3(-0.81f, 0, 5.33f), new Quaternion(0, 0, 0, 0));

            Emt.GetComponent<EnemyMoveTest>().Speed = 3;
            EShots2.GetComponent<EnemyShots>().fireRate = 0.2f;
        }

        else if (EplayerHealth.currentHealth == 300)
        {
            sp1.GetComponent<Transform>().SetPositionAndRotation(new Vector3(7.08f, 0, 5.72f), new Quaternion(0, 0, 0, 0));
            sp2.GetComponent<Transform>().SetPositionAndRotation(new Vector3(7f, 0, -7.82f), new Quaternion(0, 0, 0, 0));
            Emt.GetComponent<EnemyMoveTest>().Speed = 20;
            EShots2.GetComponent<EnemyShots>().fireRate = 0.2f;
            EShots2.GetComponent<Transform>().transform.eulerAngles = new Vector3(0, -90, 0);
        }
        else if (EplayerHealth.currentHealth == 210)
        {
            EShots2.SetActive(false);
            sp1.GetComponent<Transform>().SetPositionAndRotation(new Vector3(4.77F, 0, 5.72f), new Quaternion(0, 0, 0, 0));
            sp2.GetComponent<Transform>().SetPositionAndRotation(new Vector3(4.77f, 0, 5.72f), new Quaternion(0, 0, 0, 0));
            Emt.GetComponent<EnemyMoveTest>().Speed = 10;

        }

        else if (EplayerHealth.currentHealth <= 200 )
        {
            EShots2.SetActive(true);
            sp1.GetComponent<Transform>().SetPositionAndRotation(new Vector3(12.61F, 0, 12f), new Quaternion(0, 0, 0, 0));
            sp2.GetComponent<Transform>().SetPositionAndRotation(new Vector3(12.61f, 0, 12f), new Quaternion(0, 0, 0, 0));
            Emt.GetComponent<EnemyMoveTest>().Speed = 1;
            EShots2.GetComponent<EnemyShots>().fireRate = 0.009f;
            EShots2.GetComponent<Transform>().Rotate(new Vector3(0, 360, 0) * Time.deltaTime);
        }

    }
}

