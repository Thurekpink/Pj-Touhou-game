using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    public Text name1;
    public Text name2;
    public Text name3;
    public Text name4;

    public Text puntuacion1;
    public Text puntuacion2;
    public Text puntuacion3;
    public Text puntuacion4;

    private void Update()
    {
        if (PlayerPrefs.GetString("bettername1").Length > 0)
        {
            //Debug.Log("player1 not null");
            name1.text = PlayerPrefs.GetString("bettername1");
            puntuacion1.text = PlayerPrefs.GetInt("betterpoints1").ToString();

            if (PlayerPrefs.GetString("bettername2").Length > 0)
            {
                //Debug.Log("player2 not null");
                name2.text = PlayerPrefs.GetString("bettername2");
                puntuacion2.text = PlayerPrefs.GetInt("betterpoints2").ToString();

                if (PlayerPrefs.GetString("bettername3").Length > 0)
                {
                    // Debug.Log("player3 not null");
                    name3.text = PlayerPrefs.GetString("bettername3");
                    puntuacion3.text = PlayerPrefs.GetInt("betterpoints3").ToString();

                    if (PlayerPrefs.GetString("bettername4").Length > 0)
                    {
                        //Debug.Log("player4 not null = ." + PlayerPrefs.GetString("bettername4") + ".");
                        name4.text = PlayerPrefs.GetString("bettername4");
                        puntuacion4.text = PlayerPrefs.GetInt("betterpoints4").ToString();
                    }
                    // else Debug.Log("player4 null = ." + PlayerPrefs.GetString("bettername4") + ".");
                }

            }
        }
    }
    public void Start()
    {
        if (PlayerPrefs.GetString("bettername1").Length > 0)
        {
            //Debug.Log("player1 not null");
            name1.text = PlayerPrefs.GetString("bettername1");
            puntuacion1.text = PlayerPrefs.GetInt("betterpoints1").ToString();

            if (PlayerPrefs.GetString("bettername2").Length > 0)
            {
                //Debug.Log("player2 not null");
                name2.text = PlayerPrefs.GetString("bettername2");
                puntuacion2.text = PlayerPrefs.GetInt("betterpoints2").ToString();

                if (PlayerPrefs.GetString("bettername3").Length > 0)
                {
                    //Debug.Log("player3 not null");
                    name3.text = PlayerPrefs.GetString("bettername3");
                    puntuacion3.text = PlayerPrefs.GetInt("betterpoints3").ToString();

                    if (PlayerPrefs.GetString("bettername4").Length > 0)
                    {
                        name4.text = PlayerPrefs.GetString("bettername4");
                        puntuacion4.text = PlayerPrefs.GetInt("betterpoints4").ToString();
                    }
                    
                }

            }
        }






    }

    // Update is called once per frame
    public void Actualizar()
    {
        int puntos = PlayerPrefs.GetInt("currentpoints");
        if (puntos > 0)
        {
            if (puntos >= PlayerPrefs.GetInt("betterpoints1"))
            {
                if ((!PlayerPrefs.GetString("currentname").Equals(PlayerPrefs.GetString("bettername1"))) && (puntos != PlayerPrefs.GetInt("betterpoints1")))
                {
                    PlayerPrefs.SetString("bettername4", PlayerPrefs.GetString("bettername3"));
                    PlayerPrefs.SetInt("betterpoints4", PlayerPrefs.GetInt("betterpoints3"));

                    PlayerPrefs.SetString("bettername3", PlayerPrefs.GetString("bettername2"));
                    PlayerPrefs.SetInt("betterpoints3", PlayerPrefs.GetInt("betterpoints2"));

                    PlayerPrefs.SetString("bettername2", PlayerPrefs.GetString("bettername1"));
                    PlayerPrefs.SetInt("betterpoints2", PlayerPrefs.GetInt("betterpoints1"));

                    PlayerPrefs.SetString("bettername1", PlayerPrefs.GetString("currentname"));
                    PlayerPrefs.SetInt("betterpoints1", PlayerPrefs.GetInt("currentpoints"));
                }
               // else Debug.Log("repetido");
                
            }
            else if (puntos >= PlayerPrefs.GetInt("betterpoints2"))
            {
                if ((!PlayerPrefs.GetString("currentname").Equals(PlayerPrefs.GetString("bettername2"))) && (puntos != PlayerPrefs.GetInt("betterpoints2")))
                {
                    PlayerPrefs.SetString("bettername4", PlayerPrefs.GetString("bettername3"));
                    PlayerPrefs.SetInt("betterpoints4", PlayerPrefs.GetInt("betterpoints3"));

                    PlayerPrefs.SetString("bettername3", PlayerPrefs.GetString("bettername2"));
                    PlayerPrefs.SetInt("betterpoints3", PlayerPrefs.GetInt("betterpoints2"));

                    PlayerPrefs.SetString("bettername2", PlayerPrefs.GetString("currentname"));
                    PlayerPrefs.SetInt("betterpoints2", PlayerPrefs.GetInt("currentpoints"));
                }
                //else Debug.Log("repetido2");
                    
            }

            else if (puntos >= PlayerPrefs.GetInt("betterpoints3"))
            {
                if ((!PlayerPrefs.GetString("currentname").Equals(PlayerPrefs.GetString("bettername3"))) && (puntos != PlayerPrefs.GetInt("betterpoints3")))
                {

                    PlayerPrefs.SetString("bettername4", PlayerPrefs.GetString("bettername3"));
                    PlayerPrefs.SetInt("betterpoints4", PlayerPrefs.GetInt("betterpoints3"));

                    PlayerPrefs.SetString("bettername3", PlayerPrefs.GetString("currentname"));
                    PlayerPrefs.SetInt("betterpoints3", PlayerPrefs.GetInt("currentpoints"));
                }
               // else Debug.Log("repetido3");
            }

            else if (puntos >= PlayerPrefs.GetInt("betterpoints4"))
            {
                if ((!PlayerPrefs.GetString("currentname").Equals(PlayerPrefs.GetString("bettername4"))) && (puntos != PlayerPrefs.GetInt("betterpoints4")))
                {
                    PlayerPrefs.SetString("bettername4", PlayerPrefs.GetString("currentname"));
                    PlayerPrefs.SetInt("betterpoints4", PlayerPrefs.GetInt("currentpoints"));
                }
                // else Debug.Log("repetido4");
            }
        }
    }

    public void resetTable()
    {
        PlayerPrefs.DeleteKey("betterpoints1");
        PlayerPrefs.DeleteKey("betterpoints2");
        PlayerPrefs.DeleteKey("betterpoints3");
        PlayerPrefs.DeleteKey("betterpoints4");

        PlayerPrefs.DeleteKey("bettername1");
        PlayerPrefs.DeleteKey("bettername2");
        PlayerPrefs.DeleteKey("bettername3");
        PlayerPrefs.DeleteKey("bettername4");

        name1.text = PlayerPrefs.GetString("bettername1");
        puntuacion1.text = "";

        name2.text = PlayerPrefs.GetString("bettername2");
        puntuacion2.text = "";

        name3.text = PlayerPrefs.GetString("bettername3");
        puntuacion3.text = "";

        name4.text = PlayerPrefs.GetString("bettername4");
        puntuacion4.text = "";
        
    }
}
        
    

