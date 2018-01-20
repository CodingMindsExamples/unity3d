using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerEnter(Collider other) {
		Debug.Log ("Coin Trigger Enter! Coin"); 
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Rotate (new Vector3(2, 0, 0));
	}
}
