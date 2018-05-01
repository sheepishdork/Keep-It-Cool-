using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : MonoBehaviour {

	public GameObject rageBar;
	public RageBar rageBarScript;

	void Start() {
		rageBarScript = rageBar.GetComponent<RageBar> ();
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.name == "coin(Clone)") {
			rageBarScript.SendMessage ("Coin");
			Destroy (other.gameObject);
		} else if (other.gameObject.name == "meat(Clone)") {
			rageBarScript.SendMessage ("Meat");
			Destroy (other.gameObject);
		}
		else if (other.gameObject.name == "toys(Clone)") {
			rageBarScript.SendMessage ("Toy");
			Destroy (other.gameObject);
		}
		else if (other.gameObject.name == "gem(Clone)") {
			rageBarScript.SendMessage ("Gem");
			Destroy (other.gameObject);
		}
	}
}
