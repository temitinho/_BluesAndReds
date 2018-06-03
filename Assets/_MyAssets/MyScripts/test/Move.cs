using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour 
{
	private float thrust;
	private Rigidbody rb;




	void Start() 
	{

		rb = GetComponent<Rigidbody>();
		thrust = 200f;
		MoveFoward();
	}

	void MoveFoward()
	{
		rb.AddForce(transform.forward * thrust);
	}
	

}
