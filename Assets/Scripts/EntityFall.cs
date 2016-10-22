using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EntityFall : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D coll){

		//Destroys falling object 
		Destroy (coll);
		Debug.Log ("Destroyed!");

		//Check if the falling object is the player 
		if (coll.name == "Player") {
			//Loads current scene (Restarts Level)
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);  
		}
	}

}
