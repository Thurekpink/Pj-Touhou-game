using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary1
{
	public float xMin, xMax, zMin, zMax;
}

public class PlayerBullet : MonoBehaviour 
{
	public float speed;

	public Boundary1 boundary;

	public GameObject Shot;
	public Transform BulletSpawn;
	public float fireRate;

	private float nextFire;

	void Update()
	{
		if (Time.time > nextFire)
		{
			nextFire = Time.time + fireRate;
			Instantiate(Shot, BulletSpawn.position, BulletSpawn.rotation);
		}

	}

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		var movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		var rigidbody = GetComponent<Rigidbody> ();
		rigidbody.velocity = movement * speed;

        if (Input.GetKey("left") || Input.GetKey("a"))
        {
            gameObject.GetComponent<Animator>().SetBool("mooving", true);
           
            gameObject.GetComponent<SpriteRenderer>().flipX = false;

        }

        if (Input.GetKey("right") || Input.GetKey("d"))
        {
            gameObject.GetComponent<Animator>().SetBool("mooving", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;

        }

        if (!Input.GetKey("right") && !Input.GetKey("left") && !Input.GetKey("d") && !Input.GetKey("a"))
        {
            gameObject.GetComponent<Animator>().SetBool("mooving", false);

        }


        rigidbody.position = new Vector3 
			(
				Mathf.Clamp (rigidbody.position.x, boundary.xMin, boundary.xMax),
				0.0f,
				Mathf.Clamp (rigidbody.position.z,boundary.zMin, boundary.zMax)
			);
        
	}
} 

