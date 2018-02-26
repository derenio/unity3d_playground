using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float jumpForce = 100f;

	Rigidbody rb;
	GameController gc;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.A)) {
			Jump();
		}
	}

	void Jump() {
		rb.AddForce (transform.up * jumpForce);
	}

	void OnCollisionEnter(Collision collision) {
		GameObject otherObject = collision.gameObject;

		if (otherObject.tag == "Coin") {
			Score();
			Debug.Log("Scoooore");
		}
	}

	void Score() {
		gc.AddPoints(100);
	}
}
