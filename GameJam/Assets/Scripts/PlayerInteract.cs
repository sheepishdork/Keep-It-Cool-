using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour {

	public GameObject currentInterObj = null;
	public InteractionObject currentInterObjScript = null;

	void Update() {
		
	}

	void OnTriggerEnter(Collider other) {
		if (other.CompareTag ("interObject")) {
			currentInterObj = other.gameObject;
			currentInterObjScript = currentInterObj.GetComponent<InteractionObject> ();

		}
	}

	void OnTriggerExit(Collider other) {
		if(other.CompareTag ("interObject")) {
			if(other.gameObject == currentInterObj) {
				currentInterObj = null;
			}
		}
	}
}
