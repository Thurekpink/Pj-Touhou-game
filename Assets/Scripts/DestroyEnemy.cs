using UnityEngine;
using System.Collections;

public class DestroyEnemy : MonoBehaviour {

	public int scoreValue = 5;
	public float attackDamage = 0.25f;
	GameObject PlayerObject;
	EnemyHealth EplayerHealth;

	void Awake()
	{
		PlayerObject = GameObject.FindGameObjectWithTag ("Enemy");
		EplayerHealth = PlayerObject.GetComponent <EnemyHealth> ();
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject == PlayerObject)
		{
			EplayerHealth.TakeDamage (attackDamage);
			ScoreManager.score += scoreValue;
			Destroy (gameObject);
		}
	}
}
