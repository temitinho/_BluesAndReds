using UnityEngine;
using System.Collections;

public class Thrust : MonoBehaviour {


	private float thrust;
	private Rigidbody rb;
	private float vmax = 600;
	private float vmin = 400;
	private Transform dir;

	void Start() {
		rb = GetComponent<Rigidbody>();
		thrust = Random.Range (vmin, vmax);
		Move();
	}


	void Move()
	{
	
		rb.AddForce(transform.forward * thrust);

	}
}