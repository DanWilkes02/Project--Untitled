using UnityEngine;
using System.Collections;



public class ButtonBehaviour : MonoBehaviour {

	public GameObject movedObject;
	public int moveAmount = 5;

	private bool isDoneOnce = false;


	void OnCollisionEnter2D(Collision2D coll){
		if(isDoneOnce == false){
			movedObject.transform.position += new Vector3 (0, moveAmount, 0);

			isDoneOnce = true;
		}
	}

	void OnCollisionExit2D(Collision2D coll){
		if (isDoneOnce == true) {

			movedObject.transform.position -= new Vector3 (0, moveAmount, 0);

			isDoneOnce = false;
		}
	}
}



