using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	int score = 0;

	public GameObject coinRespawn;
	public GameObject coinPrefab;

	float nextCoinTimer = 1f;

	// Use this for initialization
	void Start () {
		score = 0;
	}

	// Update is called once per frame
	void Update () {
	}

	public void AddPoints(int points) {
		score += points;
	}

	void updateCoinLauncher() {
		nextCoinTimer -= Time.deltaTime;

		if (nextCoinTimer <= 0) {
			Debug.Log("Spawned coin");
			nextCoinTimer = Random.Range(1f, 5f);
			Instantiate(coinPrefab, coinRespawn.transform);
		}
	}
}
