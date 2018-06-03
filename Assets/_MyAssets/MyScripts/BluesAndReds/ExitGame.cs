using UnityEngine;
using System.Collections;

public class ExitGame : MonoBehaviour {


	public void Exit ()
	{
	
		Application.Quit();

	}
	
	public void Reset ()
	{
		
		GameManager.instance.Reset();
		
	}

}
