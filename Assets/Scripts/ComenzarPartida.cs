using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ComenzarPartida : MonoBehaviour
{
    public void ToGame()
    {
        Application.LoadLevel("Preparing");
    }
}
