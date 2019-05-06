using UnityEngine;
using System.Collections;

public class DestroyUs : MonoBehaviour {
	public float attackDamage = 1;
	GameObject PlayerObject;
	PlayerHealthTest playerHealth;

	void Awake()
	{
		PlayerObject = GameObject.FindGameObjectWithTag ("Player");
		playerHealth = PlayerObject.GetComponent <PlayerHealthTest> ();
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject == PlayerObject)
		{
			playerHealth.TakeDamage (attackDamage);
			Destroy (gameObject);
		}
	}
}
