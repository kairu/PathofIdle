using UnityEngine;
using System.Collections;
public class MobAttack : MonoBehaviour {

	public static MobAttack mobAttack;

	public float timeBetweenAttacks;
	public int minAttack;
	public int maxAttack;
	public int attackDamage = 1;
	float timer;

	GameObject player;
	PlayerHealth playerHealth;
	GameObject Enemy;
	MobLife mobLife;
	void Awake(){
		Enemy = GameObject.FindGameObjectWithTag ("Enemy");
		mobLife = Enemy.GetComponent<MobLife> ();
		player = GameObject.FindGameObjectWithTag ("Player");
		playerHealth = player.GetComponent<PlayerHealth> ();
	}
	void Update(){
		timer += Time.deltaTime;
		//if (timer >= timeBetweenAttacks) {
		//	Attack();
		//}
		if (playerHealth.healthSlider.value >= 0 && timer >= timeBetweenAttacks) {
			Attack();
			//Debug.Log ("Hitting");
		}
		//if (playerHealth.currentHealth <= 0) {
		//	playerHealth.healthSlider.value = playerHealth.maxHealth.maxValue;
		//}
	}

	void Attack(){

		if (timeBetweenAttacks == 0) {
			timeBetweenAttacks = 3f;
		}
		timeBetweenAttacks = mobLife.timingOfAttacks;
		timer = 0f;
		//minAttack = minAttack * mobLife.mobCount;
		//maxAttack = maxAttack * mobLife.mobCount;
		attackDamage = Random.Range (minAttack, maxAttack) * mobLife.mobCount;
		if (playerHealth.currentHealth > 0) {
			playerHealth.TakeDamage (attackDamage);
			//Debug.Log ("Alive");
		} //else {
		//	playerHealth.isAlive (playerHealth.healthSlider.value);
			//Debug.Log ("Dead");
		//}
	}
}
