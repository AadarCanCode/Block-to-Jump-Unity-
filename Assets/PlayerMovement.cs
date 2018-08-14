using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float forwardForce = 2000f;
	public float sidewaysForce = 500f;
	[SerializeField] private float bounceForce;

	public Rigidbody rb;
	// Update is called once per frame
	void FixedUpdate () {
		rb.AddForce (0, 0, forwardForce * Time.deltaTime);

		if (Input.GetKey ("d")) 
		{
			rb.AddForce (sidewaysForce * Time.deltaTime, 0, 0);
		}

		if (Input.GetKey ("a")) 
		{
			rb.AddForce (-sidewaysForce * Time.deltaTime, 0, 0);
		}
		if (Input.GetKey ("w")) 
		{
			rb.AddForce (0, bounceForce  * Time.deltaTime, 0);
		}
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, -bounceForce * Time.deltaTime, 0);
        }
        if (Input.GetKey("right"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("left"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("up"))
        {
            rb.AddForce(0, bounceForce * Time.deltaTime, 0);
        }
        if (Input.GetKey("down")){
            rb.AddForce(0, -bounceForce * Time.deltaTime, 0);
        }


			
		
	}
}
