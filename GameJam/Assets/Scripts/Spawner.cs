using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject prefabSpawns;
	public bool stopSpawning = false;
	public float spawnTime;
	public float spawnDelay;

	void Start() {
		InvokeRepeating ("SpawnObject", spawnTime, spawnDelay);

		spawnTime = Time.time;
		spawnDelay = Time.time;
	}

	void SpawnObject() {
		Instantiate (prefabSpawns, transform.position, transform.rotation);

		if (stopSpawning == true) {
			CancelInvoke ("SpawnObject");
		}
	}
}
