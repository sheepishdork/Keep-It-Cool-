using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public int speed;
	Rigidbody2D rbody;

	// Use this for initialization
	void Start () {

		rbody = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {

		Vector2 movement_vector = new Vector3 (Input.GetAxisRaw ("Horizontal"), Input.GetAxisRaw ("Vertical"));

		rbody.MovePosition (rbody.position + movement_vector * Time.deltaTime * speed);
	}
}
