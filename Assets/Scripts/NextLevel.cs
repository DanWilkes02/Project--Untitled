using UnityEngine;
using System.Collections; 
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {


	void OnTriggerStay2D(Collider2D coll){
		if (Input.GetKeyUp (KeyCode.Space)) {
			Debug.Log ("LEVEL FINISHED");
			int loadedLevel = SceneManager.GetActiveScene ().buildIndex;
			SceneManager.LoadScene (loadedLevel+1);
		}
	}
}