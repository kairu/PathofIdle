using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Experience : MonoBehaviour {

	public static Experience experience;

	public Slider experienceSlider;
	// 10 x level * 3
	double formula;
	//int a = 1;
	public int level;
	public int levelgained;
	//public int experienceToPass;
	GameObject PlayerHitPoint;
	PlayerHealth PHealth;
	public UnityEngine.UI.Text PlayerLevel;
	void Awake(){

		PlayerHitPoint = GameObject.FindGameObjectWithTag ("Player");
		PHealth = PlayerHitPoint.GetComponent<PlayerHealth> ();

		levelgained = 0;
		//level = 1;
		PlayerLevel.text = "Level: " + level;
		for(int y = 0 ; y < level; y++){
			formula += Mathf.Floor(y+300*Mathf.Pow(2,y/2));
		}
		formula = System.Convert.ToDouble(Mathf.Floor(System.Convert.ToSingle(formula)/10));
		experienceSlider.maxValue = System.Convert.ToSingle(formula);
		levelgained=1;
	}


	public void experienceGained(int passed){
		//experienceToPass = passed;
		experienceSlider.value += passed;
		if (experienceSlider.value >= experienceSlider.maxValue) {
			level++;
			experienceSlider.value=0;
			levelgained=0;
			PHealth.maxHealth.maxValue += 12;
			PHealth.maxHealth.value = PHealth.maxHealth.maxValue;
		
		}
		if( levelgained==0){

			for(int y = 0 ; y < level; y++){
				formula += Mathf.Floor(y+300*Mathf.Pow(2,y/2));
			}
			formula = System.Convert.ToDouble(Mathf.Floor(System.Convert.ToSingle(formula)/10));
			experienceSlider.maxValue = System.Convert.ToSingle(formula);
				levelgained=1;
				PlayerLevel.text = "Level: " + level;
				PHealth.startingHealth = System.Convert.ToUInt64(48 + (12 * level));
				PHealth.currentHealth = PHealth.startingHealth;
		}



	}
}
