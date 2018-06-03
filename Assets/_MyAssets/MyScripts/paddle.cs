using UnityEngine;
using System.Collections;

public class paddle : MonoBehaviour {
	

	private Camera cam;

	
	private Vector3 playerPos = new Vector3 (0, -9.5f, 0);
	void Start ()
	{

		cam = Camera.main;

	}


	
	void Update () 
	{


        Vector3 mousePos = Input.mousePosition;
        mousePos = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, cam.transform.position.y - transform.position.y));

        playerPos = new Vector3(Mathf.Clamp(mousePos.x, -8f, 8f), -9.5f, 0f);
        transform.position = playerPos;

        //if (Input.touchCount == 1)

        //{
        //    //transform.Translate (Input.touches [0].deltaPosition.x * .25f, Input.touches [0].deltaPosition.y * .25f, 0); 

        //    Touch touch = Input.GetTouch(0);

        //    float x = -8f + 16 * touch.position.x / Screen.width;
        //    float y = -8f + 16 * touch.position.y / Screen.width;
        //    //playerPos = new Vector3(Mathf.Clamp(touch.position.y, -8f, 8f), -9.5f, 0f);

        //    transform.position = new Vector3(x, y, 0);

        //}
    }
} 