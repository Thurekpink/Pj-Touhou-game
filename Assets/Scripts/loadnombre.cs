using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class loadnombre : MonoBehaviour
{
    public Text salida;
    public void cargar()
    {
        salida.text = PlayerPrefs.GetString("currentname");
    }
}
