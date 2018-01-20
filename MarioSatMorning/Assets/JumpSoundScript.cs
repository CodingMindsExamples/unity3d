using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpSoundScript : MonoBehaviour {

	public Text text;
	public Text gameoverText;

	public AudioSource jumpAudioSource;
	public AudioSource coinAudioSource;

	int counter;

	void OnTriggerEnter(Collider other) {
		Debug.Log ("Coin Trigger Enter! Player"); 
		if (other.gameObject.CompareTag ("Coin")) {
			coinAudioSource.Play ();
			Destroy (other.gameObject);
			counter++;
			text.text = "Coins: " + counter;
		} 
		if (other.gameObject.CompareTag ("Floor")) {
			Destroy (gameObject);
			gameoverText.enabled = true;
		}
	}

	// Use this for initialization
	void Start () {
		gameoverText.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Jump")) {
			jumpAudioSource.Play ();
		}
	}
}
