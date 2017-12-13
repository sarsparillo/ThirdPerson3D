using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;
	public float jumpHeight;

	public Rigidbody rb;

	void Start() {
		rb = GetComponent<Rigidbody>();
	}

	
	void Update () {
		rb.velocity = new Vector3(Input.GetAxis("Horizontal") * speed, rb.velocity.y, Input.GetAxis("Vertical") * speed);
	}
}
