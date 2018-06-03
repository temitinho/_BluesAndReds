using UnityEngine;
using System.Collections;

public class MyDestroy : MonoBehaviour {

	public GameObject explosion;
	public GameObject playerExplosion;

	void Start ()
	{

	}
	
	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Boundary" || other.tag == "Enemy"  || other.tag == "wallV" || other.tag == "wallH" || other.tag == "Ball1")
		{
			return;
		}
		
		if (explosion != null)
		{
			Instantiate(explosion, transform.position, transform.rotation);
		}
		
		if (other.tag == "Player")
		{

			Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
			Destroy (other.gameObject);
			//gameController.GameOver();
		}

		if (other.tag == "Ball2")
		{
			

			Destroy (other.gameObject);
		}


	}
}
