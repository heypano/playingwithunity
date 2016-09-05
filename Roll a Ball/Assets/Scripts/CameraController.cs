using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CameraController : MonoBehaviour {
	public GameObject player;

	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;	
	}

	// Follow Cameras, procedural animation and gathering last known states
	// guaranteed to run after everything has been processed in update, we know absolutely the player has moved this frame
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}
