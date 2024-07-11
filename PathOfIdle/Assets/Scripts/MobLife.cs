using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class MobLife : MonoBehaviour {
	//public static MobLife MLife;
	//Item Drops
	public int dropRate;
	public int whiteRate;
	public int magicRate;
	public int rareRate;
	public int uniqueRate;

	//End Item Drops
	public int count;
	public double mStartingHealth = 60;
	public Slider mMaxHealth;
	public double mCurrentHealth;
	public Slider mHealthSlider;
	public double isWhiteMobHealth = 60;
	private int _whiteCount;
	public double isMagicMobHealth = 120;
	private int _magicCount;
	public double isRareMobHealth = 360;
	private int _rareCount;
	public double isUniqueMobHealth = 300;
	private int _uniqueCount;
	public UnityEngine.UI.Text mobLife;
	public float timingOfAttacks;
	public int expDeath;
	public int mobCount;
	public GameObject mobSpace;
	public float respawnTime;
	//private string _mCapHealth;
	//private float _Holder;
	//private int _areaPass;
	//private string[] _mobColors = new string[] {"FFFFFF","0000FF","FFFF00","520000"};
	//Color newcol;
	GameObject pExperience;
	Experience experiences;
	GameObject ClassMobAttack;
	MobAttack ClassMobDamage;
	GameObject currencyHandlers;
	CurrencyHandler handlerofCurrency;
	GameObject cUpdater;
	Currency cUpdatePass;
	GameObject getArea;
	AreaMove gArea;
	int check;
	//bool spawnChecker;
	//float timer;
	//GameObject getMobUpg;
//	MobUpgrade gMobUpg;
	void Awake(){
		pExperience = GameObject.FindGameObjectWithTag("Player");
		experiences = pExperience.GetComponent<Experience>();
		ClassMobAttack = GameObject.FindGameObjectWithTag("Enemy");
		ClassMobDamage = ClassMobAttack.GetComponent<MobAttack>();
		currencyHandlers = GameObject.FindGameObjectWithTag ("Currency");
		handlerofCurrency = currencyHandlers.GetComponent<CurrencyHandler>();
		getArea = GameObject.FindGameObjectWithTag ("AreaLevel");
		gArea = getArea.GetComponent<AreaMove>();
		//getMobUpg = GameObject.FindGameObjectWithTag ("MobAndAura");
		//gMobUpg = getMobUpg.GetComponent<MobUpgrade> ();
		//cUpdater = GameObject.FindGameObjectWithTag ("SubCurrency");
		//cUpdatePass = cUpdater.GetComponent<Currency>();
		//mMaxHealth.maxValue = mStartingHealth;
		//mCurrentHealth = mStartingHealth;


	}
	/*void Start(){
		newMob();
	}*/

	void Update(){
		//_mCapHealth = mMaxHealth.maxValue.ToString ();
		//mStartingHealth = int.Parse (_mCapHealth);
		if (_magicCount == 1) {
			//Color.TryParseHexString( _mobColors[1],out newcol);
		//	newcol = Color(_mobColors[1]);
			mobLife.color = new Color32(0,0,255,255);
		} else if (_rareCount == 1) {
			//Color.TryParseHexString( _mobColors[2],out newcol);
			//newcol = System.Single.Parse(_mobColors[2]);
			mobLife.color = new Color32(255,255,0,255);
		} else if (_uniqueCount == 1) {
			//Color.TryParseHexString( _mobColors[3],out newcol);
			//newcol = System.Single.Parse(_mobColors[3]);
			mobLife.color = new Color32(80,0,0,255);
		} else if (_whiteCount == 1) {
			//Color.TryParseHexString( _mobColors[0],out newcol);
			//newcol = System.Single.Parse(_mobColors[0]);
			mobLife.color = new Color32(255,255,255,255);
		} else {
			//Color.TryParseHexString( _mobColors[0],out newcol);
			//newcol = System.Single.Parse(_mobColors[0]);
			mobLife.color = new Color32(255,255,255,255);
		}

		mobLife.text = NumberConvert.Instance.getNumbersIntoString(System.Convert.ToUInt32(mHealthSlider.value.ToString("F0"))) + " / " + NumberConvert.Instance.getNumbersIntoString(System.Convert.ToUInt32(mMaxHealth.maxValue.ToString()));
		/*if(spawnChecker){
			StartCoroutine(waitToSpawn());
		}*/
		if (mHealthSlider.value <= 0) {
			float lerp = Mathf.PingPong (Time.time, respawnTime) / respawnTime;
			float alpha = Mathf.Lerp (0, 1, lerp);
			mobSpace.GetComponent<CanvasGroup> ().alpha = alpha;
		} else {
			mobSpace.GetComponent<CanvasGroup> ().alpha = 1f;
		}
	}

	public void mTakeDamage(int mAmount){
		mCurrentHealth -= mAmount;
		mHealthSlider.value = float.Parse(mCurrentHealth.ToString());
		ismAlive (mHealthSlider.value);
	}

	public void ismAlive(float isdead){
		if (isdead <= 0) {
			check += 1;
			//spawnChecker = true;

			//Experience.experience.experienceGained(expDeath);

			//cUpdatePass.currencyTest();
			//Currency.currency.currencyUpdate();
			//_areaPass = gArea.currentArea;
			if(check == 1){
				StartCoroutine(waitToSpawn());
				StopCoroutine(waitToSpawn());
			}
				

			//Invoke("newMob",0.5f);
			//newMob();
			//spawnChecker = true;

		}
	}

	IEnumerator waitToSpawn(){
		if(_magicCount == 1){
			_magicCount = 0;
			expDeath = 2 * gArea.level;
			dropRate = magicRate * mobCount;
		}else if(_rareCount == 1){
			_rareCount = 0;
			expDeath = 3* gArea.level;
			dropRate = rareRate * mobCount;
		}else if(_uniqueCount == 1){
			_uniqueCount = 0;
			expDeath = 4* gArea.level;
			dropRate = uniqueRate * mobCount;
		}else if (_whiteCount == 1){
			_whiteCount = 0;
			expDeath = 1* gArea.level;
			dropRate = whiteRate * mobCount;
		}else {
			_whiteCount = 0;
			expDeath = 1* gArea.level;
			dropRate = whiteRate * mobCount;
		}
		mobLoot(dropRate);
		experiences.experienceGained(expDeath);
		if((gArea.currentMaxLevel - 1) == gArea.level){
			count += 1;
		}
		//fadeOutMob ();
		yield return new WaitForSeconds(respawnTime);
		newMob();
		check = 0;
		//spawnChecker = false;
	}


	public void mobLoot(int mobRate){
		switch (Random.Range (0, mobRate)) {
		default:
			handlerofCurrency.wis += 1;
			handlerofCurrency.chrom += 1;
			//CurrencyHandler.cHandler.wis += 1;
			break;
		case 522:
		case 311:
		case 222:
		case 800:
			handlerofCurrency.GCP +=1;
			//CurrencyHandler.cHandler.GCP += 1;
			break;
		}
	}

	public void newMob(){
		isWhiteMobHealth = gArea.level * (Random.Range (10, 15)) * mobCount;
		switch (Random.Range (1,1000)) {
		case 1:
		default:
			mMaxHealth.maxValue = float.Parse(isWhiteMobHealth.ToString());
			mHealthSlider.value = mMaxHealth.maxValue;
			mCurrentHealth = isWhiteMobHealth;
			_whiteCount = 1;
			timingOfAttacks = 3f;
			ClassMobDamage.maxAttack = 1 * gArea.level;
			if(_rareCount == 1){
				_rareCount = 0;
			}else if(_magicCount == 1){
				_magicCount = 0;
			}else if(_uniqueCount == 1){
				_uniqueCount = 0;
			}
			break;
		case 13:
		case 14: 
		case 15:
			isMagicMobHealth = isWhiteMobHealth * 2;
			mMaxHealth.maxValue = float.Parse(isMagicMobHealth.ToString());
			mHealthSlider.value = mMaxHealth.maxValue;
			mCurrentHealth = isMagicMobHealth;
			_magicCount = 1;
			timingOfAttacks = 2.5f;
			ClassMobDamage.maxAttack = 2 * gArea.level;
			if(_rareCount == 1){
				_rareCount = 0;
			}else if(_whiteCount == 1){
				_whiteCount = 0;
			}else if(_uniqueCount == 1){
				_uniqueCount = 0;
			}
			break;
		
		case 29:
		case 30:
			isRareMobHealth = isWhiteMobHealth * 4;
			mMaxHealth.maxValue = float.Parse(isRareMobHealth.ToString());
			mHealthSlider.value = mMaxHealth.maxValue;
			mCurrentHealth = isRareMobHealth;
			_rareCount = 1;
			timingOfAttacks = 2f;
			ClassMobDamage.maxAttack = 3 * gArea.level;
			if(_magicCount == 1){
				_magicCount = 0;
			}else if(_whiteCount == 1){
				_whiteCount = 0;
			}else if(_uniqueCount == 1){
				_uniqueCount = 0;
			}
			break;
		case 31:
			isUniqueMobHealth = isWhiteMobHealth *8;
			mMaxHealth.maxValue = float.Parse(isUniqueMobHealth.ToString());
			mHealthSlider.value = mMaxHealth.maxValue;
			mCurrentHealth = isUniqueMobHealth;
			_uniqueCount = 1;
			timingOfAttacks = 1f;
			ClassMobDamage.maxAttack = 4 * gArea.level;
			if(_magicCount == 1){
				_magicCount = 0;
			}else if(_whiteCount == 1){
				_whiteCount = 0;
			}else if(_rareCount == 1){
				_rareCount = 0;
			}
			break;

		}
		//if (Random.Range (0,16) && ismagic == 14 || ismagic == 15) {
			//if(Random.Range(1,50) < 15){
				
			//}
		//}
	}
}
