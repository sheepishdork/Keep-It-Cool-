using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RageBar : MonoBehaviour {

	Image rageBar;

	public float rage;
	public float rageOverTime;
	public float maxRage = 100f;

	void Start() {
		rageBar = GetComponent<Image> ();
	}

	void Update() {
		if (rage >= 0) {
			rage += Time.deltaTime * rageOverTime;
			rageBar.fillAmount = rage / maxRage;
		} else {
			Time.timeScale = 0;
		}
	}
}
