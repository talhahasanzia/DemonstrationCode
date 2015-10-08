using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Behaviours : MonoBehaviour {



	Vector3 StartPos = new Vector3 (0.0f, 3.0f, 0.0f);
	public GameObject Sphere;
	public GameObject Cube;
	public Slider ScaleSlider;
	public Material renderMaterial;

	// Use this for initialization
	void Start () {
		Time.timeScale = 0;


		ScaleSlider.minValue = 2;
		ScaleSlider.maxValue = 8;
		ScaleSlider.value = 2;
	}
	
	// Update is called once per frame
	void Update () {
	

		Cube.transform.localScale=new Vector3((float)ScaleSlider.value, (float)ScaleSlider.value, (float)ScaleSlider.value);

	}


	public void ResetClick()
	{

		Sphere.GetComponent<Rigidbody> ().velocity = Vector3.zero;
		//Sphere.GetComponent<Rigidbody> ().angularVelocity = Vector3.zero;
		Cube.GetComponent<Renderer> ().material = renderMaterial;
		ScaleSlider.value = 2;
		Sphere.transform.position = StartPos;
		Cube.transform.rotation = Quaternion.Euler (0, 0, 0);
		Time.timeScale = 0;

	}
	public void StartClick()
	{

		Time.timeScale = 1;


	}


}
