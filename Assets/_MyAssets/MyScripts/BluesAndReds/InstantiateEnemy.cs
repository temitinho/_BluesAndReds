using UnityEngine;
using System.Collections;

public class InstantiateEnemy : MonoBehaviour 
{
	public GameObject prefab;
	private Quaternion rotation = Quaternion.identity;
	private float ang = 45f;  
	private int xRange = 4;
	private int zRange = 4;
	private int numObjects;
	private GameObject clonePrefab;
	private Vector3 spawnerPos;
	
	void Start()
	{

		numObjects = GameManager.instance.TBalls;
		spawnerPos = transform.position;
		Spawn();
	}


	void Update()
	{

	}




	void Spawn()
	{

		for (int i = 1; i <= numObjects; i= i+2)
		{
			spawnerPos = transform.position;
			rotation.eulerAngles = new Vector3(0, ang*i, 0);
			spawnerPos = new Vector3 (Random.Range (spawnerPos.x - xRange, spawnerPos.x + xRange), 0, Random.Range (spawnerPos.z - zRange,spawnerPos.z + zRange));
			clonePrefab = Instantiate(prefab, spawnerPos, rotation ) as GameObject;
		}
	}
}