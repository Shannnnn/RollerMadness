using UnityEngine;
using System.Collections;

public class SpawnGameObjectsOnce : MonoBehaviour {

	public GameObject spawnPrefab;

	public float spawningSeconds = 5.0f;
	
	private float savedTime;
	private float secondsBetweenSpawning;

	// Use this for initialization
	void Start () {
		savedTime = Time.time;
		secondsBetweenSpawning = spawningSeconds;
	}
	
	// Update is called once per frame
	void Update () {
		if ((Time.time - savedTime >= secondsBetweenSpawning) && secondsBetweenSpawning != 0)// is it time to spawn again?
		{
			MakeThingToSpawn();
			secondsBetweenSpawning = 0;
		}	
	}

	void MakeThingToSpawn()
	{
		// create a new gameObject
		GameObject clone = Instantiate(spawnPrefab, transform.position, transform.rotation) as GameObject;
	}
}
