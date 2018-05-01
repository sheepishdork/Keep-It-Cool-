using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public float myTimer = 60;
	public Text timerText;

	void Start () {
		timerText = GetComponent<Text> ();
	}

	void Update () {
		myTimer -= Time.deltaTime;
		timerText.text = myTimer.ToString ("f0");

		if (myTimer <= 0) {
			Time.timeScale = 0;
		}
	}
}
