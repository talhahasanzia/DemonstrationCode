using UnityEngine;
using System.Collections;

public class DetectCollisions : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.gameObject.GetComponent<Rigidbody> ().detectCollisions = true;
	}
	

}
