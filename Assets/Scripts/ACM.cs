using UnityEngine;
using System.Collections;


public class ACM : MonoBehaviour
{
    public float speed;

    public Boundary1 boundary;
    GameObject PlayerObject;
    private Rigidbody rbody;
    


    void Awake()
    {
        PlayerObject = GameObject.FindGameObjectWithTag("Player");
      
    }

    void FixedUpdate()
    {
        //float moveHorizontal = Input.GetAxis("Horizontal");
        //float moveVertical = Input.GetAxis("Vertical");
        




        var rigidbody = GetComponent<Rigidbody>();
     
    


        if (PlayerObject.GetComponent<Transform>().position.x> 0 && gameObject.GetComponent<Transform>().position.x < 4)
        {
            //gameObject.GetComponent<Animator>().SetBool("Moving", true);

            //gameObject.GetComponent<SpriteRenderer>().flipX = false;
            var movement = new Vector3(1f, 0.0f, 0.0f);
            rigidbody.velocity = movement * speed;

        }

        if (PlayerObject.GetComponent<Transform>().position.x < 0 && gameObject.GetComponent<Transform>().position.x > - 4)
        {
            //gameObject.GetComponent<Animator>().SetBool("Moving", true);

            //gameObject.GetComponent<SpriteRenderer>().flipX = false;
            var movement = new Vector3(-1f, 0.0f, 0.0f);
            rigidbody.velocity = movement * speed;

        }

     
        /*    if (Input.GetKey("right"))
            {
                gameObject.GetComponent<Animator>().SetBool("Moving", true);
                gameObject.GetComponent<SpriteRenderer>().flipX = true;

            }

            if (!Input.GetKey("right") && !Input.GetKey("left"))
            {
                gameObject.GetComponent<Animator>().SetBool("Moving", false);

            }  */

        rigidbody.position = new Vector3
         (
             Mathf.Clamp(rigidbody.position.x, boundary.xMin, boundary.xMax),
             0.0f,
             Mathf.Clamp(rigidbody.position.z, boundary.zMin, boundary.zMax)
         );
    }
}

