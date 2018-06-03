using UnityEngine;
using System.Collections;

public class spawnCubeTest : MonoBehaviour {

	public GameObject prefab;
	public float offset = 0;
	private Quaternion rotation = Quaternion.identity;
	private float ang = 45f;  
	private int xRange = 4;
	private int zRange = 3;
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
		
		for (int i = 1; i <= numObjects; i= i+2)
		{
			
			rotation.eulerAngles = new Vector3(0, ang*i, 0);
			spawnerPos = new Vector3 (Random.Range (spawnerPos.x - xRange, spawnerPos.x + xRange)+ offset, 0, Random.Range (spawnerPos.z - zRange,spawnerPos.z + zRange));
			clonePrefab = Instantiate(prefab, spawnerPos, rotation ) as GameObject;
		}
	}
}
