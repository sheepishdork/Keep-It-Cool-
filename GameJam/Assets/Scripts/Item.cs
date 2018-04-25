using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {
	
	public Transform onHand;

	void PickUp() {
		this.transform.position = onHand.position;
		this.transform.parent = GameObject.Find ("player").transform;
	}

	void PutDown() {
		this.transform.parent = null;
	}
}
