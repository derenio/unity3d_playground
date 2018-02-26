using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

	public float speed = 1f;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody>().velocity = Vector3.left * speed;
	}

	// Update is called once per frame
	void Update () {
		Debug.Log("Coin.Update");
	}
}
