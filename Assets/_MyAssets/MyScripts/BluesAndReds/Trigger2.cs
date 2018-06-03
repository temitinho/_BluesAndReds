using UnityEngine;
using System.Collections;

public class Trigger2 : MonoBehaviour {

	//private int nball1 = 0;

	private void OnTriggerEnter(Collider other)
	{  
		if (other.tag == "Ball1")
		{
			//nball1++;
			GameManager.instance.AddBlueBall();
		}


		//Debug.Log("Blue Ball =" + nball1);
	
	}
	private void OnTriggerExit(Collider other)
	{  
		if (other.tag == "Ball1")
		{
			//nball1--;
			GameManager.instance.SubBlueBall();
		}


		//Debug.Log(nball2);
	}



}
