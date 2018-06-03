using UnityEngine;
using System.Collections;

public class BounceCube : MonoBehaviour 
{

	
	void OnTriggerEnter(Collider other)
	{
		
		if (other.tag == "wallV")
		{
			
			GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x * -1 , 0, GetComponent<Rigidbody>().velocity.z);
			transform.LookAt(transform.GetComponent<Rigidbody>().velocity);
			
		}
		
		if (other.tag == "wallH")
		{
			GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x  , 0, GetComponent<Rigidbody>().velocity.z * -1);
			transform.LookAt(transform.GetComponent<Rigidbody>().velocity);
			
		}
	}

	

}
