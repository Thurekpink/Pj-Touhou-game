using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class phases2_phanton1 : MonoBehaviour
{

    GameObject PlayerObject;
    EnemyHealth EplayerHealth;
    GameObject EShots;
    GameObject sp1;
    GameObject sp2;

    EnemyMoveTest Emt;

    void Awake()
    {
        PlayerObject = GameObject.FindGameObjectWithTag("Enemy");
        EplayerHealth = PlayerObject.GetComponent<EnemyHealth>();
        
        Emt = gameObject.GetComponent<EnemyMoveTest>();
        EShots = GameObject.FindGameObjectWithTag("EnemyBulletSpawnph1");
        sp1 = GameObject.FindGameObjectWithTag("sph11");
        sp2 = GameObject.FindGameObjectWithTag("sph12");

        Emt.GetComponent<EnemyMoveTest>().Speed = 1;
        EShots.SetActive(false);

    }

    void Update()
    {

        if (EplayerHealth.currentHealth == 400)
        {
            EShots.SetActive(true);
            sp1.GetComponent<Transform>().SetPositionAndRotation(new Vector3(-4.9f, 0, 3.88f), new Quaternion(0, 0, 0, 0));
            sp2.GetComponent<Transform>().SetPositionAndRotation(new Vector3(1.4f, 0, 5.33f), new Quaternion(0, 0, 0, 0));

            Emt.GetComponent<EnemyMoveTest>().Speed = 3;
            EShots.GetComponent<EnemyShots>().fireRate = 0.2f;
        }
        else if (EplayerHealth.currentHealth == 300)
        {
            sp1.GetComponent<Transform>().SetPositionAndRotation(new Vector3(-6.91f, 0, 5.72f), new Quaternion(0, 0, 0, 0));
            sp2.GetComponent<Transform>().SetPositionAndRotation(new Vector3(-6.9f, 0, -7.82f), new Quaternion(0, 0, 0, 0));
            Emt.GetComponent<EnemyMoveTest>().Speed = 15;
            //EShots.GetComponent<Transform>().SetPositionAndRotation(new Vector3(0, 0, 0), new Quaternion(180, 180, 180, 180));
            EShots.GetComponent<Transform>().transform.eulerAngles = new Vector3(0, 90, 0);



            EShots.GetComponent<EnemyShots>().fireRate = 0.2f;
        }
        else if (EplayerHealth.currentHealth == 210)
        {
            EShots.SetActive(false);
            sp1.GetComponent<Transform>().SetPositionAndRotation(new Vector3(-6.9f, 0, -9.93f), new Quaternion(0, 0, 0, 0));
            sp2.GetComponent<Transform>().SetPositionAndRotation(new Vector3(-6.9f, 0, -9.93f), new Quaternion(0, 0, 0, 0));
            Emt.GetComponent<EnemyMoveTest>().Speed = 30;
           
            EShots.GetComponent<Transform>().transform.eulerAngles = new Vector3(0, 90, 0);

        }
        else if (EplayerHealth.currentHealth == 200)
        {
            EShots.SetActive(true);
            sp1.GetComponent<Transform>().SetPositionAndRotation(new Vector3(-7.05f, 0, -1.97f), new Quaternion(0, 0, 0, 0));
            sp2.GetComponent<Transform>().SetPositionAndRotation(new Vector3(-5.9f, 0, -9.93f), new Quaternion(0, 0, 0, 0));
            Emt.GetComponent<EnemyMoveTest>().Speed = 2;
            EShots.GetComponent<EnemyShots>().fireRate = 0.01f;
         
  
        }

        else if (EplayerHealth.currentHealth == 110)
        {

            EShots.SetActive(false);
            sp1.GetComponent<Transform>().SetPositionAndRotation(new Vector3(-11.31f, 0, 14.09f), new Quaternion(0, 0, 0, 0));
            sp2.GetComponent<Transform>().SetPositionAndRotation(new Vector3(-11.31f, 0, 14.09f), new Quaternion(0, 0, 0, 0));
            Emt.GetComponent<EnemyMoveTest>().Speed = 30;
            
            EShots.GetComponent<Transform>().Rotate(new Vector3(0, 360, 0) * Time.deltaTime);


        }
        else if (EplayerHealth.currentHealth <= 100)
        {

            EShots.SetActive(true);
            sp1.GetComponent<Transform>().SetPositionAndRotation(new Vector3(-11.31f, 0, 14.09f), new Quaternion(0, 0, 0, 0));
            sp2.GetComponent<Transform>().SetPositionAndRotation(new Vector3(-11.31f, 0, 14.09f), new Quaternion(0, 0, 0, 0));
            Emt.GetComponent<EnemyMoveTest>().Speed = 1;
            EShots.GetComponent<EnemyShots>().fireRate = 0.009f;
            EShots.GetComponent<Transform>().Rotate(new Vector3(0, 360, 0) * Time.deltaTime);


        }



    }
}

