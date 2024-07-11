using UnityEngine;
using System.Collections;

public class Status : MonoBehaviour {

	public static Status stats;

	public int strength = 14;
	public int dexterity = 14;
	public int intelligence = 14;
	public string classSelected = "";
	void Awake(){
		if (stats == null) {
			DontDestroyOnLoad(gameObject);
			stats = this;
		}
		else if(stats != this){
			Destroy(gameObject);
		}
	}
}
