using UnityEngine;
using System.Collections;
using BigNumber;
public class StatDisplay : MonoBehaviour {

	public UnityEngine.UI.Text display;
	//private ulong goToInt;
	GameObject Player;
	PlayerAttack getPlayerStat;
	GameObject dpsTracker;
	DPSAttacker getDeeps;
	void Start(){
		Player = GameObject.FindGameObjectWithTag ("Skills");
		getPlayerStat = Player.GetComponent<PlayerAttack>();
		dpsTracker = GameObject.FindGameObjectWithTag ("GameManager");
		getDeeps = dpsTracker.GetComponent<DPSAttacker>();
	}
	void Update () {
		/*if (getDeeps.getDPS == null) {

		} else {
			goToInt = ulong.Parse (getDeeps.getDPS);
		}*/
		display.text = "Strength: " + Status.stats.strength + "\nDexterity: " + Status.stats.dexterity + "\nIntelligence: " + Status.stats.intelligence + "\nClickDps: "+getPlayerStat.pMinDamage + " - "+ getPlayerStat.pMaxDamage + "\nIdleDps: "+ NumberConvert.Instance.getNumbersIntoString(System.Convert.ToUInt32(getDeeps.getDPS)) ;

	}
}
