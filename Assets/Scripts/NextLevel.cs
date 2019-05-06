using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
{
    public void ToNextLevel2()
    {
        Application.LoadLevel("Level2");
    }

    public void ToNextLevel1()
    {
        Application.LoadLevel("Level1");
    }


}
