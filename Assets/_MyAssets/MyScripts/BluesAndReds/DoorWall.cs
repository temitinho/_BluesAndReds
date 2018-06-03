using UnityEngine;
using System.Collections;

public class DoorWall : MonoBehaviour {


	private Camera cam;
	
	
	private Vector3 playerPos = new Vector3 (0, 0, 0);
	void Start ()
	{
		
		cam = Camera.main;
		
	}
	
	
	
	void Update () 
	{

        //Vector3 mousePos = Input.mousePosition;
        //mousePos = cam.ScreenToWorldPoint(new Vector3(mousePos.x,mousePos.y,cam.transform.position.z - transform.position.z));

        //playerPos = new Vector3 (14, 0, Mathf.Clamp(mousePos.z, -11.5f, 11.5f));
        //transform.position = playerPos;
        if (Input.touchCount == 1)

        {
            //transform.Translate (Input.touches [0].deltaPosition.x * .25f, Input.touches [0].deltaPosition.y * .25f, 0); 

            Touch touch = Input.GetTouch(0);

            //float x = -8f + 16 * touch.position.x / Screen.width;
            float y = -14f + 28 * touch.position.y / Screen.height;
            //Vector3 pos = Input.mousePosition;
            //pos = cam.ScreenToWorldPoint(new Vector3(x, y, cam.transform.position.z - transform.position.z));

            //playerPos = new Vector3(14, 0, Mathf.Clamp(mousePos.z, -11.5f, 11.5f));
            //transform.position = playerPos;

            transform.position = new Vector3(14, 0, y);

        }
    }
}
