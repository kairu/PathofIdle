using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PlayerAttack : MonoBehaviour {

	//public static PlayerAttack pAttack;

	public int pMinDamage = 1;
	public int pMaxDamage = 3;
	public int pCritChance = 5;
	public int pCritMult = 150;
	public int pAttackDamage;

	//GameObject GameControl;
	//Status Stat;
	GameObject Enemy;
	MobLife mobLife;
	void Awake(){
		//GameControl = GameObject.FindGameObjectWithTag ("GameController");
		//Stat = GameControl.GetComponent<Status> ();
		Enemy = GameObject.FindGameObjectWithTag ("Enemy");
		mobLife = Enemy.GetComponent<MobLife> ();
		pMinDamage = Status.stats.strength;
		pMaxDamage = Status.stats.strength;
		pMinDamage = pMinDamage / 5;
		pMaxDamage = pMaxDamage / 3;
		//pMinDamage = Stat.strength / 5;
		//pMaxDamage = Stat.strength / 3;

	}
	
	public void Attack(){
		pAttackDamage = Random.Range (pMinDamage,pMaxDamage);
		mobLife.mTakeDamage (pAttackDamage);
	}
}
