using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;
	public float jumpHeight;

	private bool canJump, canMelee, canShoot;

	public Rigidbody rb;

	void Start() {
		rb = GetComponent<Rigidbody>();

		canJump = true;
	}

	
	void Update() {
		rb.velocity = new Vector3(Input.GetAxis("Horizontal") * speed, rb.velocity.y, Input.GetAxis("Vertical") * speed);

		if (Input.GetButtonDown("Jump")) {
			Jump();
		}
	}

	void Jump() {
		if (canJump) {
			rb.velocity = new Vector3(rb.velocity.x, jumpHeight, rb.velocity.z);
		}
	}

	void Melee() {
		if (canMelee) {
			Debug.Log("Melee key pressed.");
		}
	}

	void Shoot() {
		if (canShoot) {
			Debug.Log("Shoot key pressed.");
		}
	}
}
