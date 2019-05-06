using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour {

	public float startingHealth = 300;                         
	public float currentHealth;                                  
	public Slider healthSlider;

    GameObject EndMenu;
    

    void Awake ()
	{
		currentHealth = startingHealth;
        EndMenu = GameObject.FindGameObjectWithTag("endmenu");
    }

	public void TakeDamage (float amount)
	{
		currentHealth -= amount;
		healthSlider.value = currentHealth;
		if(currentHealth <= 0)
		{
            EndMenu.gameObject.SetActive(true);
            gameObject.SetActive(false);
            Time.timeScale = 0;
           

        }
    }
}