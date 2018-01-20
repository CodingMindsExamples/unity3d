using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowScript : MonoBehaviour {

	public GameObject player;
	Vector3 distance;

	// Use this for initialization
	void Start () {
		distance = this.transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = player.transform.position + distance;
	}
}
