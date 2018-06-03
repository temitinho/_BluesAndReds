using UnityEngine;
using System.Collections;

public class MyDestroyAsteroids : MonoBehaviour {
	public GameObject explosion;
	public GameObject playerExplosion;


	
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
		
		if (other.tag == "Player" || other.tag == "Ball2")
		{
			
			Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
			Destroy (other.gameObject);
			Destroy (gameObject);

		}

	
	}
}
