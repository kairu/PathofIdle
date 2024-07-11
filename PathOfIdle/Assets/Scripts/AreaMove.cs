using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Text.RegularExpressions;
public class AreaMove : MonoBehaviour {

	public int level, authorize,currentMaxLevel;
	public UnityEngine.UI.InputField placeHolder;
	public UnityEngine.UI.Text mobCounter;
	public GameObject incLvl,decLvl;
	private int _levelCheck;
	GameObject getMobLife;
	//MobAttack mAttack;
	MobLife mLife;
	void Awake(){
		getMobLife = GameObject.FindGameObjectWithTag ("Enemy");
		mLife = getMobLife.GetComponent<MobLife>();
	//	mAttack = getMobLife.GetComponent<MobAttack>();
	}
	void Start(){
		incLvl.SetActive (false);
		decLvl.SetActive (false);
		level = 1;
		currentMaxLevel = level + 1;
		mLife.newMob ();
	}
	void Update(){
		if((currentMaxLevel - 1) == level){
			if (mLife.count < authorize) {
				if(incLvl.activeInHierarchy.Equals(true)){
					incLvl.SetActive(false);
				}
				mobCounter.text = mLife.count + " / " + authorize;
			}else{
				mobCounter.text = "";
				if(incLvl.activeInHierarchy.Equals(false)){
					incLvl.SetActive(true);
				}
			}
		}else {
			mobCounter.text = "";
		}
	}

	public void increaseLevel(){
		//2 1
		if ((currentMaxLevel - 1) == level) {
			//Debug.Log("What");
			if (mLife.count >= authorize) {
				level += 1;
				placeHolder.text = level.ToString ();
				currentMaxLevel = level + 1;
				mLife.count = 0;
				mLife.newMob ();
			}
		} else {
			//Debug.Log("here");
			if(currentMaxLevel <= level){
			
			}else{
				level += 1;
				placeHolder.text = level.ToString ();
				mLife.newMob ();
			}
		}
		if(decLvl.activeInHierarchy.Equals(false)){
			decLvl.SetActive(true);
		}
			//if(currentMaxLevel <= level){
			
	}

	public void decreaseLevel(){
		if (level == 1) {
			placeHolder.text = level.ToString ();
			//if(level == 2){
				
			//}
		} else {
			if(decLvl.activeInHierarchy.Equals(false)){
				decLvl.SetActive(true);
			}
			if(level == 2 || level == 1){
				decLvl.SetActive(false);
			}
			if(incLvl.activeInHierarchy.Equals(false)){
				incLvl.SetActive(true);
			}
			level -= 1;
			placeHolder.text = level.ToString ();
			mLife.count = 0;
			mLife.newMob ();
		}
	}

	public void currentArea(){
		_levelCheck = int.Parse (placeHolder.text);
		if (currentMaxLevel <= _levelCheck) {
			placeHolder.text = level.ToString();
			if(currentMaxLevel == _levelCheck){
				if(mLife.count >= authorize){
					level = _levelCheck;
					placeHolder.text = level.ToString();
					currentMaxLevel = level + 1;
					mLife.count = 0;
					mLife.newMob();
					if(incLvl.activeInHierarchy.Equals(true)){
						incLvl.SetActive(false);
					}
				}
			}
		} else {
			level = int.Parse (placeHolder.text);
			if((currentMaxLevel - 1) == level){
				if(incLvl.activeInHierarchy.Equals(true)){
					incLvl.SetActive(false);
				}
				if(decLvl.activeInHierarchy.Equals(false)){
				decLvl.gameObject.SetActive(true);
				}
			}else{
				_levelCheck = int.Parse(placeHolder.text);
				if( _levelCheck == 1){
					decLvl.SetActive(false);
					if(incLvl.activeInHierarchy.Equals(false)){
						incLvl.SetActive(true);
					}
				}else{
					if(incLvl.activeInHierarchy.Equals(false)){
						incLvl.SetActive(true);
					}
					if(decLvl.activeInHierarchy.Equals(false)){
						decLvl.SetActive(true);
					}
				}
			}
			mLife.newMob ();
		}
		//Debug.Log (_level);
	}
}
