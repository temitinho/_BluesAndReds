using UnityEngine;
using System.Collections;

public class MySpawnAsteroids : MonoBehaviour {

	public GameObject prefab;


	private Quaternion rotation = Quaternion.identity;
	private float ang = 45f;  
	private int xRange = 2;
	private int zRange = 2;
	public int numObjects;
	private GameObject clonePrefab;
	private Vector3 spawnerPos;
	
	void Start()
	{
		
		
		spawnerPos = transform.position;
		Spawn();
	}
	
	
	void Spawn()
	{
		
		for (int i = 0; i <= numObjects; i++)
		{
			spawnerPos = transform.position;
			rotation.eulerAngles = new Vector3(0, ang*i, 0);
			spawnerPos = new Vector3 (Random.Range (spawnerPos.x - xRange, spawnerPos.x + xRange), 0, Random.Range (spawnerPos.z - zRange,spawnerPos.z + zRange));
			clonePrefab = Instantiate(prefab, spawnerPos, rotation ) as GameObject;
		}
	}
}
