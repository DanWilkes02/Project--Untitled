using UnityEngine;
using System.Collections;

public class EntityFall : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D coll){
		Destroy (coll);
	}
}
