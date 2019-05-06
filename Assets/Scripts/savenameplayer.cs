using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class savenameplayer : MonoBehaviour
{
    public InputField entrada;
    
    public void guardarnombre()
    {
        PlayerPrefs.SetString("currentname", entrada.text);
    }
}
