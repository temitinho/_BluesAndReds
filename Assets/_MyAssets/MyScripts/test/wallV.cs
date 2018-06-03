using UnityEngine;
using System.Collections;

public class wallV : MonoBehaviour 
{


	public GameObject ball1;
	public GameObject ball2;

	
	
	
	void OnTriggerEnter(Collider other)
	{

		if (other.tag == "Ball1")
		{

			ball1.GetComponent<Rigidbody>().velocity = new Vector3(ball1.GetComponent<Rigidbody>().velocity.x * -1 , 0, ball1.GetComponent<Rigidbody>().velocity.z);
			//ball2.rigidbody.velocity = new Vector3(ball2.rigidbody.velocity.x * -1 , 0, ball2.rigidbody.velocity.z);
		
			
		}
		
		if (other.tag == "Ball2")
		{
			
			//ball1.rigidbody.velocity = new Vector3(ball1.rigidbody.velocity.x * -1 , 0, ball1.rigidbody.velocity.z);
			ball2.GetComponent<Rigidbody>().velocity = new Vector3(ball2.GetComponent<Rigidbody>().velocity.x * -1 , 0, ball2.GetComponent<Rigidbody>().velocity.z);
			
			
		}
	}
}
