using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class phases : MonoBehaviour
{

    GameObject PlayerObject;
    EnemyHealth EplayerHealth;
    GameObject EShots;
    GameObject sp1;
    GameObject sp2;
    GameObject sp3;
    EnemyMoveTest Emt;

    void Awake()
    {
        EplayerHealth = gameObject.GetComponent<EnemyHealth>();
        Emt = gameObject.GetComponent<EnemyMoveTest>();
        EShots = GameObject.FindGameObjectWithTag("EnemyBulletSpawn");
        sp1 = GameObject.FindGameObjectWithTag("sp1");
        sp2 = GameObject.FindGameObjectWithTag("sp2");
        sp3 = GameObject.FindGameObjectWithTag("sp3");
    }

    void Update()
    {  
        
        if (EplayerHealth.currentHealth == 300) {
            Emt.GetComponent<EnemyMoveTest>().Speed = 8;
            EShots.GetComponent<EnemyShots>().fireRate = 0.1f;
        }
        else if (EplayerHealth.currentHealth == 200)
        {
            Emt.GetComponent<EnemyMoveTest>().Speed = 9;
            EShots.GetComponent<EnemyShots>().fireRate = 0.09f;
        }
       
        else if (EplayerHealth.currentHealth == 160)
        {
            Emt.GetComponent<EnemyMoveTest>().Speed = 10;
            EShots.GetComponent<EnemyShots>().fireRate = 0.08f;
        }

        else if (EplayerHealth.currentHealth == 140)
        {
            Emt.GetComponent<EnemyMoveTest>().Speed = 1;
            EShots.GetComponent<EnemyShots>().fireRate = 0.08f;
        }

        if (EplayerHealth.currentHealth == 135 && EplayerHealth.currentHealth > 100)
        {


            sp1.GetComponent<Transform>().SetPositionAndRotation(new Vector3(1.44f, 0, 10.97f), new Quaternion(0, 0, 0, 0));
            sp2.GetComponent<Transform>().SetPositionAndRotation(new Vector3(-1, 0, 7.11f), new Quaternion(0, 0, 0, 0));
            sp3.GetComponent<Transform>().SetPositionAndRotation(new Vector3(-3.37f, 0, 10.01f), new Quaternion(0, 0, 0, 0));
            EShots.GetComponent<EnemyShots>().fireRate = 1;
            Emt.GetComponent<EnemyMoveTest>().Speed = 10;

        }


        if (EplayerHealth.currentHealth <= 130 && EplayerHealth.currentHealth > 100)
        {


            sp1.GetComponent<Transform>().SetPositionAndRotation(new Vector3(1.44f, 0, 10.97f), new Quaternion(0, 0, 0, 0));
            sp2.GetComponent<Transform>().SetPositionAndRotation(new Vector3(-1, 0, 7.11f), new Quaternion(0, 0, 0, 0));
            sp3.GetComponent<Transform>().SetPositionAndRotation(new Vector3(-3.37f, 0, 10.01f), new Quaternion(0, 0, 0, 0));
            EShots.GetComponent<EnemyShots>().fireRate = 0.0009f;
            Emt.GetComponent<EnemyMoveTest>().Speed = 10;




        }


        if (EplayerHealth.currentHealth <= 120 && EplayerHealth.currentHealth > 100)
        {


            sp1.GetComponent<Transform>().SetPositionAndRotation(new Vector3(2.56f, 0, 9.16f), new Quaternion(0, 0, 0, 0));
            sp2.GetComponent<Transform>().SetPositionAndRotation(new Vector3(-1, 0, 7.65f), new Quaternion(0, 0, 0, 0));
            sp3.GetComponent<Transform>().SetPositionAndRotation(new Vector3(-4.40f, 0, 9.12f), new Quaternion(0, 0, 0, 0));
            EShots.GetComponent<EnemyShots>().fireRate = 0.0009f;
            Emt.GetComponent<EnemyMoveTest>().Speed = 6;




        }

        if (EplayerHealth.currentHealth <= 115 && EplayerHealth.currentHealth > 100)
        {


            //sp1.GetComponent<Transform>().SetPositionAndRotation(new Vector3(1.44f, 0, 10.97f), new Quaternion(0, 0, 0, 0));
            //sp2.GetComponent<Transform>().SetPositionAndRotation(new Vector3(-1, 0, 7.11f), new Quaternion(0, 0, 0, 0));
            //sp3.GetComponent<Transform>().SetPositionAndRotation(new Vector3(-3.37f, 0, 10.01f), new Quaternion(0, 0, 0, 0));
            EShots.GetComponent<EnemyShots>().fireRate = 0.0009f;
            Emt.GetComponent<EnemyMoveTest>().Speed = 2;





        }

        if (EplayerHealth.currentHealth <= 95 && EplayerHealth.currentHealth > 90)
        {


            sp1.GetComponent<Transform>().SetPositionAndRotation(new Vector3(0, 0, 3), new Quaternion(0, 0, 0, 0));
            sp2.GetComponent<Transform>().SetPositionAndRotation(new Vector3(0, 0, 3), new Quaternion(0, 0, 0, 0));
            sp3.GetComponent<Transform>().SetPositionAndRotation(new Vector3(0, 0, 3), new Quaternion(0, 0, 0, 0));
            EShots.GetComponent<EnemyShots>().fireRate = 1;
            EShots.GetComponent<Transform>().Rotate(new Vector3(0, 50, 0) * Time.deltaTime);

        }

        if (EplayerHealth.currentHealth <= 90 && EplayerHealth.currentHealth > 80)
        {


            sp1.GetComponent<Transform>().SetPositionAndRotation(new Vector3(0, 0, 3), new Quaternion(0, 0, 0, 0));
            sp2.GetComponent<Transform>().SetPositionAndRotation(new Vector3(0, 0, 3), new Quaternion(0, 0, 0, 0));
            sp3.GetComponent<Transform>().SetPositionAndRotation(new Vector3(0, 0, 3), new Quaternion(0, 0, 0, 0));
            EShots.GetComponent<EnemyShots>().fireRate = 0.0000001f;
            EShots.GetComponent<Transform>().Rotate(new Vector3(0, 100, 0) * Time.deltaTime);

        }

        if (EplayerHealth.currentHealth <= 80 && EplayerHealth.currentHealth > 70)
        {


            sp1.GetComponent<Transform>().SetPositionAndRotation(new Vector3(0, 0, 3), new Quaternion(0, 0, 0, 0));
            sp2.GetComponent<Transform>().SetPositionAndRotation(new Vector3(0, 0, 3), new Quaternion(0, 0, 0, 0));
            sp3.GetComponent<Transform>().SetPositionAndRotation(new Vector3(0, 0, 3), new Quaternion(0, 0, 0, 0));
            EShots.GetComponent<EnemyShots>().fireRate = 0.0000001f;
            EShots.GetComponent<Transform>().Rotate(new Vector3(0, 125, 0) * Time.deltaTime);

        }

        if (EplayerHealth.currentHealth <= 70 && EplayerHealth.currentHealth > 50)
        {
        
       
            sp1.GetComponent<Transform>().SetPositionAndRotation(new Vector3(0, 0, 3), new Quaternion(0, 0, 0, 0));
            sp2.GetComponent<Transform>().SetPositionAndRotation(new Vector3(0, 0, 3), new Quaternion(0, 0, 0, 0));
            sp3.GetComponent<Transform>().SetPositionAndRotation(new Vector3(0, 0, 3), new Quaternion(0, 0, 0, 0));
            EShots.GetComponent<EnemyShots>().fireRate = 0.0000001f;
            EShots.GetComponent<Transform>().Rotate(new Vector3(0, 150, 0) * Time.deltaTime);

        }

        if (EplayerHealth.currentHealth <= 50)
        {


            sp1.GetComponent<Transform>().SetPositionAndRotation(new Vector3(0, 0, 3), new Quaternion(0, 0, 0, 0));
            sp2.GetComponent<Transform>().SetPositionAndRotation(new Vector3(0, 0, 3), new Quaternion(0, 0, 0, 0));
            sp3.GetComponent<Transform>().SetPositionAndRotation(new Vector3(0, 0, 3), new Quaternion(0, 0, 0, 0));
            EShots.GetComponent<EnemyShots>().fireRate = 0.0000001f;
            EShots.GetComponent<Transform>().Rotate(new Vector3(0, 200, 0) * Time.deltaTime);

        }

    }
}

