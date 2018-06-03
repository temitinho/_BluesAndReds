using UnityEngine;
using System.Collections;

[System.Serializable]
public class Done_Boundary 
{
	public float xMin, xMax, zMin, zMax;
}

[RequireComponent (typeof (CharacterController))]

public class Done_PlayerController : MonoBehaviour
{
	public float rotationSpeed = 450;

	private float acceleration = 5;
	private Quaternion targetRotation;
	private Vector3 currentVelocityMod;
	private CharacterController controller;
	
	private Camera cam;
	private Vector3 playerPos = new Vector3 (0, 0, 0);
	
	public float speed;
	public float tilt;
	public Done_Boundary boundary;

	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;
	private float nextFire;

	void Start()
	{
		controller = GetComponent<CharacterController>();

		cam = Camera.main;
	}
	
	void Update ()
	{
		if (Input.GetButton("Fire1") && Time.time > nextFire) 
		{
			nextFire = Time.time + fireRate;
			Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
			GetComponent<AudioSource>().Play ();
		}
	}

	void FixedUpdate ()
	{
		ControlMouse();
	}

	void ControlMouse() {
		
		Vector3 mousePos = Input.mousePosition;
		mousePos = cam.ScreenToWorldPoint(new Vector3(mousePos.x,mousePos.y,cam.transform.position.y - transform.position.y));
		targetRotation = Quaternion.LookRotation(mousePos - new Vector3(transform.position.x,0,transform.position.z));
		transform.eulerAngles = Vector3.up * Mathf.MoveTowardsAngle(transform.eulerAngles.y,targetRotation.eulerAngles.y,rotationSpeed * Time.deltaTime);
		
		Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"),0,Input.GetAxisRaw("Vertical"));
		
		currentVelocityMod = Vector3.MoveTowards(currentVelocityMod,input,acceleration * Time.deltaTime);
		Vector3 motion = currentVelocityMod;

		float moveVertical = Input.GetAxis ("Vertical");
		GetComponent<Rigidbody>().AddForce (transform.forward * moveVertical* speed );
	}


}
