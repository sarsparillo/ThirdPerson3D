using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    [Header("Basic stats for movement")]
	public float speed;
	public float jumpHeight;
    public float gravityScale;

	private bool canJump, canMelee, canShoot;

    public CharacterController controller;
    private Vector3 moveDirection;

	void Start() {
        controller = GetComponent<CharacterController>();

		canJump = true;
	}

	
	void Update() {
        moveDirection = new Vector3(Input.GetAxis("Horizontal") * speed, 0f, Input.GetAxis("Vertical") * speed);

		if (Input.GetButtonDown("Jump")) {
			Jump();
		}

        moveDirection.y = moveDirection.y + (Physics.gravity.y * gravityScale);
        controller.Move(moveDirection * Time.deltaTime);
	}

	void Jump() {
		if (canJump) {
            moveDirection.y = jumpHeight;
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
