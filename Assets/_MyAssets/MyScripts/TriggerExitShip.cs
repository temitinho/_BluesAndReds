using UnityEngine;
using System.Collections;

public class TriggerExitShip : MonoBehaviour {

	public GameObject Ship;




	void OnTriggerExit(Collider other) {

		if (other.tag == "Boundary" || other.tag == "Enemy"  || other.tag == "wallV" || other.tag == "wallH" || other.tag == "Ball1" || other.tag == "Ball2")
		{
			return;
		}



		float x = Ship.transform.position.x; 
		float z = Ship.transform.position.z;
		Ship.transform.position = new Vector3 (x, 0, z);
	}
}
