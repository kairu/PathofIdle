using UnityEngine;
using System.Collections;

public class SelectCharacter : MonoBehaviour {

	public Transform goToMePassive;
	public GameObject holderParent;
	public GameObject passiveTree;
	public GameObject backPassive;
	public GameObject MainGameController;
	//public UnityEngine.UI.Text Class;
	//GameObject go;
	void Awake(){
		if(goToMePassive.gameObject.activeInHierarchy.Equals(true)){
		goToMePassive.gameObject.SetActive (false);
		}

		if(backPassive.activeInHierarchy.Equals(true)){
			backPassive.SetActive(false);
		}

		if(holderParent.activeInHierarchy.Equals(true)){
			holderParent.SetActive(false);
		}
	}
	public void ChangeToScene(string sceneToChange){
		Application.LoadLevel (sceneToChange);
	}
	public void Character(string Class){
		if (Class == "Witch") {
			Status.stats.strength = 14;
			Status.stats.intelligence = 32;
			Status.stats.dexterity = 14;
			Status.stats.classSelected = "Witch";
		}else if (Class == "Shadow") {
			Status.stats.strength = 14;
			Status.stats.intelligence = 23;
			Status.stats.dexterity = 23;
			Status.stats.classSelected = "Shadow";
		}else if (Class == "Ranger") {
			Status.stats.strength = 14;
			Status.stats.intelligence = 14;
			Status.stats.dexterity = 32;
			Status.stats.classSelected = "Ranger";
		}else if (Class == "Duelist") {
			Status.stats.strength = 23;
			Status.stats.intelligence = 14;
			Status.stats.dexterity = 23;
			Status.stats.classSelected = "Duelsit";
		}else if (Class == "Marauder") {
			Status.stats.strength = 32;
			Status.stats.intelligence = 14;
			Status.stats.dexterity = 14;
			Status.stats.classSelected = "Marauder";
		}else if (Class == "Templar") {
			Status.stats.strength = 23;
			Status.stats.intelligence = 23;
			Status.stats.dexterity = 14;
			Status.stats.classSelected = "Templar";
		}else if (Class == "Scion") {
			Status.stats.strength = 20;
			Status.stats.intelligence = 20;
			Status.stats.dexterity = 20;
			Status.stats.classSelected = "Scion";
		}
		Application.LoadLevel ("MainGame");

	}

	public void PassiveTree(){
		if (goToMePassive.gameObject.activeInHierarchy.Equals (false) && holderParent.activeInHierarchy.Equals(false)) {
			goToMePassive.gameObject.SetActive(true);
			holderParent.SetActive(true);
			if(backPassive.activeInHierarchy.Equals(false)){
				backPassive.SetActive(true);
			}
			Camera.main.orthographic = true;
			//go = Instantiate (passiveTree) as GameObject;
			//go.transform.SetParent (goToMePassive, false);
			//go.transform.position = goToMePassive.transform.position;
			passiveTree.transform.position = goToMePassive.transform.position;
			Camera.main.cullingMask = ~(1<<5);
			MainGameController.GetComponent<PassiveRaycastBlocker>().UnblockRaycast();
		}
		//go.transform.parent = goToMePassive;
	}

	public void DestroyPassiveTree(){
		//Destroy (go);
		Camera.main.orthographic = false;
		if(goToMePassive.gameObject.activeInHierarchy.Equals(true) && holderParent.activeInHierarchy.Equals(true)){
			goToMePassive.gameObject.SetActive(false);
			holderParent.SetActive(false);
		}
		if(backPassive.activeInHierarchy.Equals(true)){
			backPassive.SetActive(false);
		}
		Camera.main.cullingMask |= (1<<5);
		MainGameController.GetComponent<PassiveRaycastBlocker>().BlockRaycast();
	}

}
