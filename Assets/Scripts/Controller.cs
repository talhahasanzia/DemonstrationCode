using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

	Vector3 NewPos;
	Vector3 NewRot;
	Rigidbody Rigid;


	// Use this for initialization
	void Start () {


		Rigid = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {

		float pitch, yaw, roll;

		pitch = Input.GetAxis ("Mouse Y");
		yaw = Input.GetAxis ("Mouse X");
		roll=Input.GetAxis ("Roll");

		transform.Rotate (-pitch, yaw, -roll);




		if (Input.GetKey (KeyCode.W))
			Rigid.AddRelativeForce (transform.forward * 50);
		else if (Input.GetKey (KeyCode.S))
			Rigid.AddRelativeForce (-transform.forward * 50);
		else if (Input.GetKey (KeyCode.D))
			Rigid.AddRelativeForce (transform.right * 50);
		else if (Input.GetKey (KeyCode.D))
			Rigid.AddRelativeForce (-transform.right * 50);
		else
			Rigid.velocity = Vector3.zero;
		
	}
}
