using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class phases2 : MonoBehaviour
{

    GameObject PlayerObject;
    EnemyHealth EplayerHealth;
    GameObject EShots;
    GameObject EShots2;
    GameObject sp1;
    GameObject sp2;
    GameObject sp3;
    GameObject sp4;
    EnemyMoveTest Emt;

    void Awake()
    {
        EplayerHealth = gameObject.GetComponent<EnemyHealth>();
        Emt = gameObject.GetComponent<EnemyMoveTest>();
        EShots = GameObject.FindGameObjectWithTag("EnemyBulletSpawn");
        EShots2 = GameObject.FindGameObjectWithTag("pls");
        sp1 = GameObject.FindGameObjectWithTag("sp1");
        sp2 = GameObject.FindGameObjectWithTag("sp2");
        sp3 = GameObject.FindGameObjectWithTag("sp3");
        sp4 = GameObject.FindGameObjectWithTag("sp4");
        Emt.GetComponent<EnemyMoveTest>().Speed = 1;
        EShots.SetActive(false);
        EShots2.SetActive(false);
    }

    void Update()
    {

        if (EplayerHealth.currentHealth == 400)
        {
            EShots.SetActive(true);
            sp1.GetComponent<Transform>().SetPositionAndRotation(new Vector3(-5.4f, 0, 2.68f), new Quaternion(0, 0, 0, 0));
            sp2.GetComponent<Transform>().SetPositionAndRotation(new Vector3(0.92f, 0, 4.81f), new Quaternion(0, 0, 0, 0));
            sp3.GetComponent<Transform>().SetPositionAndRotation(new Vector3(0.92f, 0, 4.81f), new Quaternion(0, 0, 0, 0));
            sp4.GetComponent<Transform>().SetPositionAndRotation(new Vector3(4.64f, 0, 2.68f), new Quaternion(0, 0, 0, 0));
            Emt.GetComponent<EnemyMoveTest>().Speed = 6f;
            EShots.GetComponent<EnemyShots>().fireRate = 0.15f;
        }
       

        else if (EplayerHealth.currentHealth == 300)
        {
            sp1.GetComponent<Transform>().SetPositionAndRotation(new Vector3(-4.87f, 0, 2.29f), new Quaternion(0, 0, 0, 0));
            sp2.GetComponent<Transform>().SetPositionAndRotation(new Vector3(-0.04f, 0, 6.37f), new Quaternion(0, 0, 0, 0));
            sp3.GetComponent<Transform>().SetPositionAndRotation(new Vector3(-0.04f, 0, 6.37f), new Quaternion(0, 0, 0, 0));
            sp4.GetComponent<Transform>().SetPositionAndRotation(new Vector3(4.95f, 0, 3.35f), new Quaternion(0, 0, 0, 0));
            Emt.GetComponent<EnemyMoveTest>().Speed = 6;
            EShots.GetComponent<EnemyShots>().fireRate = 0.15f;
        }

        else if (EplayerHealth.currentHealth == 200)
        {
            sp1.GetComponent<Transform>().SetPositionAndRotation(new Vector3(-4.22f, 0, 8.22f), new Quaternion(0, 0, 0, 0));
            sp2.GetComponent<Transform>().SetPositionAndRotation(new Vector3(-0.04f, 0, 6.37f), new Quaternion(0, 0, 0, 0));
            sp3.GetComponent<Transform>().SetPositionAndRotation(new Vector3(-0.04f, 0, 6.37f), new Quaternion(0, 0, 0, 0));
            sp4.GetComponent<Transform>().SetPositionAndRotation(new Vector3(4.47f, 0, 4.66f), new Quaternion(0, 0, 0, 0));
            Emt.GetComponent<EnemyMoveTest>().Speed = 5;
            EShots.GetComponent<EnemyShots>().fireRate = 0.2f;
        }
        else if (EplayerHealth.currentHealth == 100)
        {
            EShots.SetActive(false);
            EShots2.SetActive(true);
            EShots2.GetComponent<EnemyShots>().fireRate = 3f;
            sp1.GetComponent<Transform>().SetPositionAndRotation(new Vector3(-4.87f, 0, 4.42f), new Quaternion(0, 0, 0, 0));
            sp2.GetComponent<Transform>().SetPositionAndRotation(new Vector3(-0.04f, 0, 6.37f), new Quaternion(0, 0, 0, 0));
            sp3.GetComponent<Transform>().SetPositionAndRotation(new Vector3(-0.04f, 0, 6.37f), new Quaternion(0, 0, 0, 0));
            sp4.GetComponent<Transform>().SetPositionAndRotation(new Vector3(4.47f, 0, 4.66f), new Quaternion(0, 0, 0, 0));
            Emt.GetComponent<EnemyMoveTest>().Speed = 5;
            
        }
    }
}

