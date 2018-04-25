using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour {

	public GameObject currentInterObj = null;
	public InteractionObject currentInterObjScript = null;

	void Update() {
		if (Input.GetKeyDown (KeyCode.E) && currentInterObj) {
			if (currentInterObjScript.item) {
				currentInterObj.SendMessage ("Update");
			}
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.CompareTag ("interObject")) {
			currentInterObj = other.gameObject;
			currentInterObjScript = currentInterObj.GetComponent<InteractionObject> ();

		}
	}

	void OnTriggerExit2D(Collider2D other) {
		if(other.CompareTag ("interObject")) {
			if(other.gameObject == currentInterObj) {
				currentInterObj = null;
			}
		}
	}
}
