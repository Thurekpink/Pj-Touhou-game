using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealthTest : MonoBehaviour
{
	public float startingHealth = 1;                         
	public float currentHealth;                                  
	public Slider healthSlider;
    public bool infinitas = false;
    [SerializeField]
    GameObject DeathMenu;

    public void vidasinfinitas()
    {
        if (infinitas)
            currentHealth = 20000;
        else
            currentHealth = 1;

    }                     


	void Awake ()
	{
		currentHealth = startingHealth;
        Time.timeScale = 1;

    }

	public void TakeDamage (float amount)
	{
		currentHealth -= amount;
		healthSlider.value = currentHealth;
		if(currentHealth <= 0)
		{
            //panel.SetActive(true); // Show menu
            DeathMenu.gameObject.SetActive(true); 
            gameObject.SetActive(false);
            Time.timeScale = 0;
           
            
            //Destroy (gameObject);
            //Application.LoadLevel(Application.loadedLevel);
            //Application.LoadLevel("Menu");
        }
	}
}