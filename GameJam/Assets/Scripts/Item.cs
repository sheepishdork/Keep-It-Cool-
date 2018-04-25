using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

	bool carrying;
 	GameObject currentInterObj;

	void Update () {
		if (carrying) {
			Carry (currentInterObj);
		} else {
			pickUp ();
		}
	}

	void Carry(GameObject o) {
		
	}

	void pickUp() {
		if (Input.GetKeyDown (KeyCode.E)) {
			
		}
	}
}
