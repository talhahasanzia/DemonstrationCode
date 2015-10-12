using UnityEngine;
using System.Collections;

public class DroneController : MonoBehaviour {


	Rigidbody Handler_Physics;




	// Use this for initialization
	void Start () {
		Handler_Physics = gameObject.GetComponent<Rigidbody> ();
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {


		if(Input.GetKeyDown(KeyCode.UpArrow))
		{

			Handler_Physics.AddRelativeForce(transform.forward*100);
			                             



		}

	
	}
}
