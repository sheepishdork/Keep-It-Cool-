using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : MonoBehaviour {

	public GameObject rageBar;
	public RageBar rageBarScript;
	public AudioSource Ding;

	void Start() {
		rageBarScript = rageBar.GetComponent<RageBar> ();

		Ding = GetComponent<AudioSource> ();
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.name == "coin(Clone)") {
			rageBarScript.SendMessage ("Coin");
			Destroy (other.gameObject);
			Ding.Play ();
		} else if (other.gameObject.name == "meat(Clone)") {
			rageBarScript.SendMessage ("Meat");
			Destroy (other.gameObject);
			Ding.Play ();
		}
		else if (other.gameObject.name == "toys(Clone)") {
			rageBarScript.SendMessage ("Toy");
			Destroy (other.gameObject);
			Ding.Play ();
		}
		else if (other.gameObject.name == "gem(Clone)") {
			rageBarScript.SendMessage ("Gem");
			Destroy (other.gameObject);
			Ding.Play ();
		}
	}
}
