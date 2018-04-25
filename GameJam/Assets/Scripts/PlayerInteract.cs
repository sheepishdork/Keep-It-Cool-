using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour {

	public GameObject currentInterObj = null;
	public InteractionObject currentInterObjScript = null;
	bool carrying;

	void Start() {
		carrying = false;
	}

	void Update() {
		if (Input.GetKey(KeyCode.E) && currentInterObj) {
			if (currentInterObjScript.item) {
				carrying = true;
				currentInterObj.SendMessage ("PickUp");
			}
		}

		if (Input.GetKeyUp (KeyCode.E) && carrying) {
			if (currentInterObjScript.item) {
				carrying = false;
				currentInterObj.SendMessage ("PutDown");
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
