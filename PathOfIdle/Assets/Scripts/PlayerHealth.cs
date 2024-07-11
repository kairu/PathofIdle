using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PlayerHealth : MonoBehaviour {

	public static PlayerHealth pHealth;

	public ulong startingHealth = 48; // base health 60
	public Slider maxHealth; // Maximum health of the player
	public ulong currentHealth;
	public Slider healthSlider; // UI Health
	public UnityEngine.UI.Text Life;
	private string _CapHealth;
	GameObject pExperience;
	Experience experiences;
	//private int _SubHealth;
	GameObject getPortals;
	CurrencyHandler gPortals;
	GameObject getArea;
	AreaMove gArea;
	GameObject getMob;
	MobLife gMob;
	void Awake(){
		//_CapHealth = startingHealth.ToString ();
		//_SubHealth = int.Parse (_CapHealth);
		//_CapHealth = maxHealth.maxValue.ToString();
		//_SubHealth = int.Parse(_CapHealth);
		//startingHealth = _SubHealth;

		pExperience = GameObject.FindGameObjectWithTag("Player");
		experiences = pExperience.GetComponent<Experience>();
		getPortals = GameObject.FindGameObjectWithTag ("Currency");
		gPortals = getPortals.GetComponent<CurrencyHandler>();
		getArea = GameObject.FindGameObjectWithTag ("AreaLevel");
		gArea = getArea.GetComponent<AreaMove>();
		getMob = GameObject.FindGameObjectWithTag ("Enemy");
		gMob = getMob.GetComponent<MobLife>();
		startingHealth += System.Convert.ToUInt64(12 * experiences.level);
		maxHealth.maxValue = startingHealth;
		currentHealth = startingHealth;
	}
		
	void Update(){
		//maxHealth = maxHealth.maxValue;
		//_CapHealth = maxHealth.maxValue.ToString();
		//_CapHealth = maxHealth.maxValue.ToString ();
		//startingHealth = int.Parse (_CapHealth);
		Life.text = NumberConvert.Instance.getNumbersIntoString(System.Convert.ToUInt32(healthSlider.value.ToString("F0"))) +" / " + NumberConvert.Instance.getNumbersIntoString(System.Convert.ToUInt32(maxHealth.maxValue.ToString()));

	}
	public void TakeDamage(int amount){
		currentHealth -= System.Convert.ToUInt64(amount);
		healthSlider.value = currentHealth;
		isAlive (healthSlider.value);
		maxHealth.maxValue = startingHealth;
	}

	public void isAlive(float isdead){
		if (isdead <= 0) {
			if(gPortals.port >= System.Convert.ToUInt64(experiences.level)){
				gPortals.port -= System.Convert.ToUInt64(experiences.level);
			}else{
				if(gArea.level == 1){

				}else{
					gArea.level -= 1;
					gArea.placeHolder.text = gArea.level.ToString();
					if(gArea.incLvl.activeInHierarchy.Equals(false)){
						gArea.incLvl.SetActive(true);
					}
				}
				gMob.newMob();
			}
			healthSlider.value = maxHealth.maxValue;
			currentHealth = startingHealth;
		}
	}
	/*private bool toggleTxt = false;
	void OnGUI(){
		toggleTxt = GUI.Toggle(new Rect(95, 50, -95, 50), toggleTxt, "A Toggle text");
	}*/
}
