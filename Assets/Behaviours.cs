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



		Cube.GetComponent<Renderer> ().material = renderMaterial;
		Cube.transform.rotation = Quaternion.Euler (0, 0, 0);

		ScaleSlider.value = 2;

		Sphere.transform.position = StartPos;
		Sphere.GetComponent<Rigidbody> ().velocity = Vector3.zero;

		Time.timeScale = 0;

	}
	public void StartClick()
	{

		Time.timeScale = 1;


	}
	public void XRotatePositive()
	{
		Cube.transform.Rotate (5, 0, 0);


	}
	public void XRotateNegative()
	{
		Cube.transform.Rotate (-5, 0, 0);
		
		
	}
	public void YRotatePositive()
	{
		Cube.transform.Rotate (0, 5, 0);
		
		
	}
	public void YRotateNegative()
	{
		Cube.transform.Rotate (0, -5, 0);
		
		
	}
	public void ZRotatePositive()
	{
		Cube.transform.Rotate (0, 0, 5);
		
		
	}
	public void ZRotateNegative()
	{
		Cube.transform.Rotate (0, 0, -5);
		
		
	}
}
