using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class DPSDisplay : MonoBehaviour {

	public Vector3 mousePosition;
	//public int count;
	public UnityEngine.UI.Text displayer;
	public GameObject idleHide;
	string classSelector;
	//public int thisClicked;
	//public int gcpInHand;

	//GameObject gemCost;
	//CurrencyHandler cCost;
	GameObject getClass;
	Status getCharacter;
	//GameObject getSkillGems;
	//SkillGems skillGemTake;
	void Awake(){
		//getSkillGems = GameObject.FindGameObjectWithTag ("IdleGems");
		//skillGemTake = getSkillGems.GetComponent<SkillGems> ();
		getClass = GameObject.FindGameObjectWithTag ("GameController");
		getCharacter = getClass.GetComponent<Status> ();
		//gemCost = GameObject.FindGameObjectWithTag ("Currency");
		//cCost = gemCost.GetComponent<CurrencyHandler>();
		classSelector = getCharacter.classSelected;
		//gcpInHand = cCost.GCP;
	}
	public void idleDisplayHover(){
		if(idleHide.activeInHierarchy.Equals(false)){
		idleHide.gameObject.SetActive (true);
		}
		mousePosition = (Vector3.right * 30) + Input.mousePosition;
		//gcpInHand = cCost.GCP;
		//this.GetComponent<SkillGems>().maraIdleDps;
		this.GetComponent<SkillGems>().computeCost ();
		if (classSelector == "Marauder") {
			displayer.text = "BaseDPS: "+this.GetComponent<SkillGems>().maraIdleDps + "\nWisdom Cost: " +this.GetComponent<SkillGems>().gemCostWis+ "\n Chromatic Cost: " + this.GetComponent<SkillGems>().gemCostChrom;
			//trueDps = maraIdleDps;
		}else if(classSelector == "Templar"){
			displayer.text = "BaseDPS: "+this.GetComponent<SkillGems>().tempIdleDps + "\nWisdom Cost: " +this.GetComponent<SkillGems>().gemCostWis + "\n Chromatic Cost: " + this.GetComponent<SkillGems>().gemCostChrom;
			//trueDps = tempIdleDps;
		}else if(classSelector == "Witch"){
			displayer.text = "BaseDPS: "+this.GetComponent<SkillGems>().witcIdleDps + "\nWisdom Cost: " +this.GetComponent<SkillGems>().gemCostWis + "\n Chromatic Cost: " + this.GetComponent<SkillGems>().gemCostChrom;
			//trueDps = witcIdleDps;
		}else if(classSelector == "Shadow"){
			displayer.text = "BaseDPS: "+this.GetComponent<SkillGems>().shadIdleDps+ "\nWisdom Cost: " +this.GetComponent<SkillGems>().gemCostWis + "\n Chromatic Cost: " + this.GetComponent<SkillGems>().gemCostChrom;
			//trueDps = shadIdleDps;
		}else if(classSelector == "Ranger"){
			displayer.text = "BaseDPS: "+this.GetComponent<SkillGems>().rangIdleDps+ "\nWisdom Cost: " +this.GetComponent<SkillGems>().gemCostWis + "\n Chromatic Cost: " + this.GetComponent<SkillGems>().gemCostChrom;
			//trueDps = rangIdleDps;
		}else if(classSelector == "Duelist"){
			displayer.text = "BaseDPS: "+this.GetComponent<SkillGems>().duelIdleDps+ "\nWisdom Cost: " +this.GetComponent<SkillGems>().gemCostWis + "\n Chromatic Cost: " + this.GetComponent<SkillGems>().gemCostChrom;
			//trueDps = duelIdleDps;
		}else if(classSelector == "Scion"){
			displayer.text = "BaseDPS: "+this.GetComponent<SkillGems>().scioIdleDps+ "\nWisdom Cost: " +this.GetComponent<SkillGems>().gemCostWis + "\n Chromatic Cost: " + this.GetComponent<SkillGems>().gemCostChrom;
			//trueDps = scioIdleDps;
		}
		idleHide.transform.position = mousePosition;
	}
	public void idleDisplayExit(){
		if(idleHide.activeInHierarchy.Equals(true)){
		idleHide.gameObject.SetActive (false);
		}
	}

	/*public void onPurchase(){
		if (gcpInHand >= cost) {
			trueDps += trueDps;
			count +=1;
			gcpInHand = gcpInHand - cost;
			cCost.GCP = gcpInHand;
		}
	}*/
}
