using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float speed = 10.0f;

	Rigidbody rigidbody;
	Vector3 velocity;

	void Start () {
		rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		velocity = new Vector3( Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical") ).normalized * speed;
	}
	
	void FixedUpdate () {
		rigidbody.MovePosition( rigidbody.position + velocity * Time.fixedDeltaTime );
	}
}
