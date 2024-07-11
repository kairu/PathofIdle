using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class OnHovers : MonoBehaviour {
	public UnityEngine.UI.Text textToDisplay;
	string maxExp;
	string currentExp;
	//private string _valuePass;
	private int _isHovered;
	public GameObject hideText;
	Vector3 mousePos;
	//public Vector3 mousePosY;
	//public Vector3 mousePosX;
	GameObject pExperience;
	Experience experiences;
	void Awake(){
		pExperience = GameObject.FindGameObjectWithTag("Player");
		experiences = pExperience.GetComponent<Experience>();
		//hideText.gameObject.SetActive(false);
	}

	public void ExperienceHover(){
		//mousePosY = Vector3(0,Input.mousePosition.y,0);
		//mousePosX = Input.mousePosition.x;
		//if(_isHovered == 0){
		if(hideText.activeInHierarchy.Equals(false)){
			hideText.SetActive(true);
		}
		mousePos = (Vector3.down * 10) + Input.mousePosition;
		hideText.transform.position = mousePos;
		//	_isHovered = 1;
		//}
		//_valuePass = experiences.experienceSlider.maxValue.ToString ();
		maxExp = experiences.experienceSlider.maxValue.ToString ("n0");
		//_valuePass = experiences.experienceSlider.value.ToString ();
		currentExp = experiences.experienceSlider.value.ToString ("n0");
		textToDisplay.text = currentExp + " / " + maxExp + " To Level Up";
		//hideText.transform.position = (Vector3.down * 10) + Input.mousePosition;
		//textToDisplay.rectTransform.position = 
		//textToDisplay.rectTransform.position = ;
	}
	public void ExperienceOnExit(){
		//textToDisplay.text = "";
		if(hideText.activeInHierarchy.Equals(true)){
		hideText.SetActive(false);
		}
		//_isHovered = 0;
	}

}
