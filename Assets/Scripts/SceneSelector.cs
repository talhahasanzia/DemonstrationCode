using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SceneSelector : MonoBehaviour {

	public GameObject RoomScene;
	public GameObject ParkScene;
	public GameObject CityScene;
	public GameObject StartMenu;


	public Button ReselectButton;


	// Use this for initialization
	void Start () {
	




		SetRelativeToScreen ();

		ReselectButton.gameObject.SetActive(false);

		RoomScene.SetActive (false);
		ParkScene.SetActive (false);
		CityScene.SetActive (false);
		StartMenu.SetActive (true);


	}
	
	// Update is called once per frame
	void Update () {
	
	}



	void SetRelativeToScreen()
	{

		ReselectButton.transform.position=new Vector3(
								(float)(((GetComponent<RectTransform>().rect.width)/2)+50),
			(float)(Screen.height-(GetComponent<RectTransform>().rect.height)/2),
		                                              0.0f);


	}

	public void OnEmptyRoomClicked()
	{

		ReselectButton.gameObject.SetActive(true);
		RoomScene.SetActive (true);
		ParkScene.SetActive (false);
		CityScene.SetActive (false);
		StartMenu.SetActive (false);


	}
	public void OnParkClicked()
	{

		ReselectButton.gameObject.SetActive(true);
		RoomScene.SetActive (false);
		ParkScene.SetActive (true);
		CityScene.SetActive (false);
		StartMenu.SetActive (false);





	}
	public void OnCityClicked()
	{

		ReselectButton.gameObject.SetActive(true);
		RoomScene.SetActive (false);
		ParkScene.SetActive (false);
		CityScene.SetActive (true);
		StartMenu.SetActive (false);



	}
	public void OnReSelectClicked()
	{

		ReselectButton.gameObject.SetActive(false);
		RoomScene.SetActive (false);
		ParkScene.SetActive (false);
		CityScene.SetActive (false);
		StartMenu.SetActive (true);

	}

}
