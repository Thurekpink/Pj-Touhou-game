using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class godmode : MonoBehaviour
{

    GameObject PlayerObject;
    PlayerHealthTest playerHealth;

    void Awake()
    {
        PlayerObject = GameObject.FindGameObjectWithTag("Player");
        playerHealth = PlayerObject.GetComponent<PlayerHealthTest>();
    }

    public void vidasinf()
    {
      
        playerHealth.infinitas = true;
        playerHealth.vidasinfinitas();

    }
}
