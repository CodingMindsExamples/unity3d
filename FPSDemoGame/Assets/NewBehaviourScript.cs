using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	public float distance;
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1")) {
			AudioSource audioSource = GetComponent<AudioSource> ();
			audioSource.Play ();
			Animation animation = GetComponent<Animation> ();
			animation.Play ();

			RaycastHit hit;
			Physics.Raycast (
				this.transform.position, 
				this.transform.TransformDirection (Vector3.forward), 
				out hit);
			distance = hit.distance;
			hit.transform.SendMessage ("MakeDamage");
		}	
	}
}
