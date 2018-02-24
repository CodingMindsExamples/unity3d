using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMove : MonoBehaviour {

	float timeToChange = 3;
	Vector3 direction = new Vector3(1, 0, 0);
	// Use this for initialization
	void Start () {
		
	}
	bool isDead = false;
	public void MakeDamage() {
		if (!isDead) {
			GetComponent<Animation> ().Play ("back_fall");
			isDead = true;
		}
		//Destroy (this.gameObject);
	}

	// Update is called once per frame
	void Update () {
		if (!isDead) {
			timeToChange = timeToChange - Time.deltaTime;
			if (timeToChange < 0) {
				int horizontalMovement = Random.Range (-1, 1);
				int verticalMovement = Random.Range (-1, 1);
				direction = new Vector3 (horizontalMovement, 0, verticalMovement);
				timeToChange = 3;
				GetComponent<Animation> ().Play ("attack");
			}
			this.transform.Translate (direction * Time.deltaTime);
		}
	}
}
