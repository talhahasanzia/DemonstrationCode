using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SliderEvents : MonoBehaviour {
	public GameObject Cube;
	public Slider XRotSlider;
	public Slider YRotSlider;
	public Slider ZRotSlider;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void RotateCube()
	{
		Cube.transform.rotation = Quaternion.Euler ((float)XRotSlider.value, (float)YRotSlider.value, (float)ZRotSlider.value);
		
		
	}
	

}
