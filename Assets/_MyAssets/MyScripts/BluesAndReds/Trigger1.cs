using UnityEngine;
using System.Collections;

public class Trigger1 : MonoBehaviour {

	//private int nball2 = 0;

	private void OnTriggerEnter(Collider other)
	{  
		if (other.tag == "Ball2")
		{


			GameManager.instance.AddRedBall();
		}


	
	}
	private void OnTriggerExit(Collider other)
	{  
		if (other.tag == "Ball2")
		{

			GameManager.instance.SubRedBall();
		}

	}



}
