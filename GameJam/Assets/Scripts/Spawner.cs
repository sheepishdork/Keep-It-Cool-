using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public Transform[] spawnLocations;
	public GameObject[] prefabSpawns;
	public GameObject[] cloneSpawns;

	void Start() {
		spawnObject ();
	}
	void spawnObject() {
		cloneSpawns[0] = Instantiate(prefabSpawns[0], spawnLocations[0].transform.position, Quaternion.Euler(0,0,0)) as GameObject;
		cloneSpawns[1] = Instantiate(prefabSpawns[1], spawnLocations[1].transform.position, Quaternion.Euler(1,1,1)) as GameObject;
		cloneSpawns[2] = Instantiate(prefabSpawns[2], spawnLocations[2].transform.position, Quaternion.Euler(2,2,2)) as GameObject;
		cloneSpawns[3] = Instantiate(prefabSpawns[3], spawnLocations[3].transform.position, Quaternion.Euler(3,3,3)) as GameObject;
	}

}
