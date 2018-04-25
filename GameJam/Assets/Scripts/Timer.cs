using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public float myTimer = 15;
	public Text timerText;

	void Start () {
		timerText = GetComponent<Text> ();
	}

	void Update () {
		myTimer -= Time.deltaTime;
		timerText.text = myTimer.ToString ("f0");
		print (myTimer);
	}
}
