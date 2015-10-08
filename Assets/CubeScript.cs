using UnityEngine;
using System.Collections;

public class CubeScript : MonoBehaviour {

	public Material[] Materials;
	Rigidbody PhysicsRigid;
	Renderer RenderComponent;
	int CurrentMat=0;
	// Use this for initialization
	void Start () {
	

		RenderComponent = this.GetComponent<Renderer> ();
		PhysicsRigid = this.GetComponent<Rigidbody> ();
		PhysicsRigid.detectCollisions = true;

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col)
	{


		if (CurrentMat == 0) {
		
			CurrentMat = 1;
			RenderComponent.material = Materials [CurrentMat];
		
		} else {
		
		
			CurrentMat=0;
			RenderComponent.material=Materials[CurrentMat];

		
		}


	}


}
