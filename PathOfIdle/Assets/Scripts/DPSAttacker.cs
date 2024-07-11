using UnityEngine;
using System.Collections;
public class DPSAttacker : MonoBehaviour {

	//public SkillGems[] items;
	/*GameObject dPSAtt;
	MobLife dPSToAttack;*/
	public double getDPS;
	/*GameObject skillGem;
	SkillGems dpsToTake;
	void Awake(){
		dPSAtt = GameObject.FindGameObjectWithTag("Enemy");
		dPSToAttack = dPSAtt.GetComponent<MobLife>();
		skillGem = GameObject.FindGameObjectWithTag ("IdleGems");
		dpsToTake = skillGem.GetComponent<SkillGems>();
	}*/
	// Use this for initialization
	/*void Start () {
		StartCoroutine (autoTick ());
	}*/

	/*public decimal getAttackPerSec(){
		decimal tick = 0;
			tick += decimal.Parse((getDPS * dpsToTake.gemLvl).ToString("F2"));
	/*	foreach (SkillGems item in items){
			tick += decimal.Parse((item.generalDPS * item.gemLvl).ToString("F4"));
			Debug.Log(item.generalDPS +" >>>" + item.gemLvl);
			//_getDPS = SkillGems.skillgem.generalDPS;
		}*/
		/*foreach (ItemTickUpg item in items) {
			tick += item.count * item.tickValue;
		}
		//Debug.Log (tick);
		return tick;
	}

	public void autoHitPerSec(){
		dPSToAttack.mCurrentHealth -= getAttackPerSec () / 10;
		dPSToAttack.mHealthSlider.value = float.Parse(dPSToAttack.mCurrentHealth.ToString("F2"));
		dPSToAttack.ismAlive (dPSToAttack.mHealthSlider.value);
		//click.gold += getGoldPerSec ()/10; or mob hp
	}
	
	IEnumerator autoTick(){
		while (true) {
			autoHitPerSec();
			yield return new WaitForSeconds(0.10f);
		}
	}*/
}
