using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RageBar : MonoBehaviour {

	Image rageBar;

	public GameObject fire;
	Animator anim;

	private float lastPlay;

	public float rage;
	public float rageOverTime;
	public float maxRage = 100f;

	void Start() {
		rageBar = GetComponent<Image> ();
		anim = fire.GetComponent<Animator>();
	}

	void Update() {
		if (rage >= 0 && rage < 100) {
			rage += Time.deltaTime * rageOverTime;
			rageBar.fillAmount = rage / maxRage;
		} else if (rage <= 0) {
			rage += Time.deltaTime * rageOverTime;
			rageBar.fillAmount = rage / maxRage;
		}else {
			Time.timeScale = 0;
		}

		if (Time.time - lastPlay >= 6) {
			lastPlay = Time.time;
			anim.SetBool ("isFlaming",true);		
			anim.Play ("fire1");
		} else {
			anim.SetBool ("isFlaming",false);
			fire.GetComponent<Animator>
		}
	}

	public void Coin() {
		rage -= 20;
	}

	public void Meat() {
		rage -= 10;
	}

	public void Gem() {
		rage -= 25;
	}

	public void Toy() {
		rage -= 5;
	}
}
