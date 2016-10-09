using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float speed;
	public float jumpVelocity;
	private bool ableToJump;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) {
			
			transform.position += Vector3.right * speed * Time.deltaTime;

		} else if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) {
			
			transform.position += Vector3.left * speed * Time.deltaTime;

		} 

		if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.Space)) {
			
			transform.position += Vector3.up * jumpVelocity * Time.deltaTime;
		}


	}


}


