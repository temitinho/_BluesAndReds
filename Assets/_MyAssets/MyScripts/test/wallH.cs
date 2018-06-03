using UnityEngine;
using System.Collections;

public class wallH : MonoBehaviour {

	public Rigidbody rb;
	public Rigidbody rb2;


	
	void OnTriggerEnter(Collider other)
	{

		if (other.tag == "Ball1")
		{

			rb.velocity = new Vector3(rb.velocity.x , 0, rb.velocity.z  * -1 );
			//rb2.velocity = new Vector3(rb2.velocity.x , 0, rb2.velocity.z * -1);

			
		}
		
		if (other.tag == "Ball2")
		{
			
			//rb.velocity = new Vector3(rb.velocity.x , 0, rb.velocity.z  * -1 );
			rb2.velocity = new Vector3(rb2.velocity.x , 0, rb2.velocity.z * -1);
			
			
		}

	}
}
