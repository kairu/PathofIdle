using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using BigNumber;
public class SkillGems : MonoBehaviour {
	//public static SkillGems skillgem;
	public int maraWisBaseCost,tempWisBaseCost,witcWisBaseCost,shadWisBaseCost,rangWisBaseCost,duelWisBaseCost,scioWisBaseCost; //wisdom base cost
	public int maraChromBaseCost,tempChromBaseCost,witcChromBaseCost,shadChromBaseCost,rangChromBaseCost,duelChromBaseCost,scioChromBaseCost; //Chromatic basecost
	public float maraIdleDps, tempIdleDps, witcIdleDps, shadIdleDps, rangIdleDps, duelIdleDps, scioIdleDps; // base damage
	public float maraAttInt, tempAttInt, witchAttInt, shadAttInt, rangAttInt, duelAttInt, scioAttInt; // attack interval
	public double maraDPS,tempDPS,witcDPS,shadDPS,rangDPS,duelDPS,scioDPS; // overall damage
	//public static decimal generalDPS;
	public Image skillImage;
	public UnityEngine.UI.Text gemName;
	public Sprite MaraSprite;
	public string gemMara;
	public Sprite TempSprite;
	public string gemTemp;
	public Sprite WitcSprite;
	public string gemWitc;
	public Sprite ShadSprite;
	public string gemShad;
	public Sprite RangSprite;
	public string gemRang;
	public Sprite DuelSprite;
	public string gemDuel;
	public Sprite ScioSprite;
	public string gemScio;
	//public int actualDPS;
	public int gemLvl;
	//public int count;
	public BigInteger gemCostWis,gemCostChrom;
	//public float gemTimeAttack;
	public Color Affordable;
	public Color Broke;
	float timer;
	string classSelected;
	//private string[] _gemColors = new string[] {"000000","0000FF","FFFF00","520000"};
	GameObject getClass;
	Status getCharacter;
	GameObject getCurrency;
	CurrencyHandler currencyGet;
	GameObject Manager;
	DPSAttacker genDPS;
	GameObject getDPSDisplay;
	DPSDisplay dpsDisplayer;
	//GameObject getTier;
	//GemTierUpg takeTier;
	GameObject dPSAtt;
	MobLife dPSToAttack;
	//Color newCol;
	float alphaScale;
	bool colorCheck = true;
	Color temp;
	void Awake(){
		getClass = GameObject.FindGameObjectWithTag ("GameController");
		getCharacter = getClass.GetComponent<Status> ();
		getCurrency = GameObject.FindGameObjectWithTag ("Currency");
		currencyGet = getCurrency.GetComponent<CurrencyHandler>();
		Manager = GameObject.FindGameObjectWithTag ("GameManager");
		genDPS = Manager.GetComponent<DPSAttacker> ();
		getDPSDisplay = GameObject.FindGameObjectWithTag ("IdleGems");
		dpsDisplayer = getDPSDisplay.GetComponent<DPSDisplay> ();
		//getTier = GameObject.FindGameObjectWithTag ("TierUpg");
		//takeTier = getTier.GetComponent<GemTierUpg>();
		dPSAtt = GameObject.FindGameObjectWithTag("Enemy");
		dPSToAttack = dPSAtt.GetComponent<MobLife>();

		classSelected = getCharacter.classSelected;
		computeCost ();
		DisplayGems ();
		RankUp ();
	}

	void Update(){

		if (ulong.Parse(currencyGet.wis.ToString()) >= gemCostWis && ulong.Parse(currencyGet.chrom.ToString()) >= gemCostChrom) {
		//	if(colorCheck){
		//		GetComponent<Image>().color = Affordable;
		//		temp = GetComponent<Image>().color;
		//		colorCheck = false;
			//}
		//	alphaScale= Mathf.PingPong(Time.time * 10, 150);
			//temp.a = alphaScale;
			GetComponent<Image>().color = Affordable;
		} else {
			//colorCheck = true;
			GetComponent<Image>().color = Broke;
		}

		if(gemLvl > 0){
			timer += Time.deltaTime;
			if(classSelected == "Marauder"){
				if(timer >= maraAttInt){
					GemAttack ();
				}
			}else if(classSelected == "Templar"){
				if(timer >= tempAttInt){
					GemAttack ();
				}
			}else if(classSelected == "Witch"){
				if(timer >= witchAttInt){
					GemAttack ();
				}
			}else if(classSelected == "Shadow"){
				if(timer >= shadAttInt){
					GemAttack ();
				}
			}else if(classSelected == "Ranger"){
				if(timer >= rangAttInt){
					GemAttack ();
				}
			}else if(classSelected == "Duelist"){
				if(timer >= duelAttInt){
					GemAttack ();
				}
			}else if(classSelected == "Scion"){
				if(timer >= scioAttInt){
					GemAttack ();
				}
			}

		}
	}
	// cost = Mathf.Round(baseCost * Mathf.Pow(1.15f,count));

	public void RankUp(){

		if (this.GetComponentInChildren<GemTierUpg>().isBlue == 1 && this.GetComponentInChildren<GemTierUpg>().isRare == 0 && this.GetComponentInChildren<GemTierUpg>().isUnique == 0) {
			//Color.TryParseHexString (_gemColors [1], out newCol);
			//Blue
			gemName.color = new Color32(0,0,255,255);
			this.GetComponentInChildren<Outline>().effectColor = new Color32(255,255,255,255);
		} else if (this.GetComponentInChildren<GemTierUpg>().isBlue == 1 && this.GetComponentInChildren<GemTierUpg>().isRare == 1 && this.GetComponentInChildren<GemTierUpg>().isUnique == 0) {
			//Color.TryParseHexString (_gemColors [2], out newCol);
			//Rare
			gemName.color = new Color32(255,255,0,255);
			this.GetComponentInChildren<Outline>().effectColor = new Color32(0,0,0,255);
		} else if (this.GetComponentInChildren<GemTierUpg>().isBlue == 1 && this.GetComponentInChildren<GemTierUpg>().isRare == 1 && this.GetComponentInChildren<GemTierUpg>().isUnique == 1) {
			//Color.TryParseHexString (_gemColors [3], out newCol);
			//Unique
			gemName.color = new Color32(80,0,0,255);
			this.GetComponentInChildren<Outline>().effectColor = new Color32(0,0,0,255);
		} else {
			//Color.TryParseHexString (_gemColors [0],out newCol);
			//White
			gemName.color = new Color32(0,0,0,255);
			this.GetComponentInChildren<Outline>().effectColor = new Color32(255,255,255,255);
		}
	}

	public void OnPurchase(){
		computeCost ();
		if (classSelected == "Marauder") {
			if(System.Convert.ToUInt64(currencyGet.wis) >= gemCostWis &&System.Convert.ToUInt64(currencyGet.chrom) >= gemCostChrom){
				currencyGet.wis -= gemCostWis;
				currencyGet.chrom -= gemCostChrom;
				gemLvl += 1;
				maraDPS += double.Parse(maraIdleDps.ToString("F2"));

				genDPS.getDPS += double.Parse((maraIdleDps / maraAttInt).ToString("F2"));
				//Debug.Log(generalDPS);
			}
		} else if (classSelected == "Templar") {
			if(System.Convert.ToUInt64(currencyGet.wis) >= gemCostWis && System.Convert.ToUInt64(currencyGet.chrom) >= gemCostChrom){
				currencyGet.wis -= gemCostWis;
				currencyGet.chrom -= gemCostChrom;
				gemLvl += 1;
				tempDPS += double.Parse(tempIdleDps.ToString("F2"));
				genDPS.getDPS += double.Parse((tempIdleDps / tempAttInt).ToString("F2"));
			}
		} else if (classSelected == "Witch") {
			if(System.Convert.ToUInt64(currencyGet.wis) >= gemCostWis && System.Convert.ToUInt64(currencyGet.chrom) >= gemCostChrom){
				currencyGet.wis -= gemCostWis;
				currencyGet.chrom -= gemCostChrom;
				gemLvl += 1;
				witcDPS += double.Parse(witcIdleDps.ToString("F2"));
				genDPS.getDPS += double.Parse((witcIdleDps / witchAttInt).ToString("F2"));
			}
		} else if (classSelected == "Shadow") {
			if(System.Convert.ToUInt64(currencyGet.wis) >= gemCostWis && System.Convert.ToUInt64(currencyGet.chrom) >= gemCostChrom){
				currencyGet.wis -= gemCostWis;
				currencyGet.chrom -= gemCostChrom;
				gemLvl += 1;
				shadDPS += double.Parse(shadIdleDps.ToString("F2"));
				genDPS.getDPS += double.Parse((shadIdleDps / shadAttInt).ToString("F2"));
			}
		} else if (classSelected == "Ranger") {
			if(System.Convert.ToUInt64(currencyGet.wis) >= gemCostWis && System.Convert.ToUInt64(currencyGet.chrom) >= gemCostChrom){
				currencyGet.wis -= gemCostWis;
				currencyGet.chrom -= gemCostChrom;
				gemLvl += 1;
				rangDPS += double.Parse(rangIdleDps.ToString("F2"));
				genDPS.getDPS += double.Parse((rangIdleDps / rangAttInt).ToString("F2"));
			}
		}else if(classSelected == "Duelist"){
			if(System.Convert.ToUInt64(currencyGet.wis) >= gemCostWis && System.Convert.ToUInt64(currencyGet.chrom) >= gemCostChrom){
				currencyGet.wis -= gemCostWis;
				currencyGet.chrom -= gemCostChrom;
				gemLvl += 1;
				duelDPS += double.Parse(duelIdleDps.ToString("F2"));
				genDPS.getDPS += double.Parse((duelIdleDps / duelAttInt).ToString("F2"));
			}
		}else if(classSelected == "Scion"){
			if(System.Convert.ToUInt64(currencyGet.wis) >= gemCostWis && System.Convert.ToUInt64(currencyGet.chrom) >= gemCostChrom){
				currencyGet.wis -= gemCostWis;
				currencyGet.chrom -= gemCostChrom;
				gemLvl += 1;
				scioDPS += double.Parse(scioIdleDps.ToString("F2"));
				genDPS.getDPS += double.Parse((scioIdleDps / scioAttInt).ToString("F2"));
			}
		}
		DisplayGems ();
		dpsDisplayer.idleDisplayHover ();

	}
	// cost = Mathf.Round(baseCost * Mathf.Pow(1.15f,count));
	public void computeCost(){
		if (classSelected == "Marauder") {
			gemCostWis = System.Convert.ToUInt64(Mathf.Round ( maraWisBaseCost* Mathf.Pow (1.15f,gemLvl)));
			gemCostChrom = System.Convert.ToUInt64(Mathf.Round ( maraChromBaseCost* Mathf.Pow (1.15f,gemLvl)));
			if(gemCostWis == 0 && gemCostChrom == 0){
				gemCostWis = System.Convert.ToUInt64(maraWisBaseCost);
				gemCostChrom = System.Convert.ToUInt64(maraChromBaseCost);
			}
		} else if (classSelected == "Templar") {
			gemCostWis = System.Convert.ToUInt64(Mathf.Round ( tempWisBaseCost* Mathf.Pow (1.15f,gemLvl)));
			gemCostChrom = System.Convert.ToUInt64(Mathf.Round ( tempChromBaseCost* Mathf.Pow (1.15f,gemLvl)));
			if(gemCostWis == 0 && gemCostChrom == 0){
				gemCostWis = System.Convert.ToUInt64(tempWisBaseCost);
				gemCostChrom = System.Convert.ToUInt64(tempChromBaseCost);
			}
		} else if (classSelected == "Witch") {
			gemCostWis = System.Convert.ToUInt64(Mathf.Round ( witcWisBaseCost* Mathf.Pow (1.15f,gemLvl)));
			gemCostChrom = System.Convert.ToUInt64(Mathf.Round ( witcChromBaseCost* Mathf.Pow (1.15f,gemLvl)));
			if(gemCostWis == 0 && gemCostChrom == 0){
				gemCostWis = System.Convert.ToUInt64(witcWisBaseCost);
				gemCostChrom = System.Convert.ToUInt64(witcChromBaseCost);
			}
		} else if (classSelected == "Shadow") {
			gemCostWis = System.Convert.ToUInt64(Mathf.Round ( shadWisBaseCost* Mathf.Pow (1.15f,gemLvl)));
			gemCostChrom = System.Convert.ToUInt64(Mathf.Round ( shadChromBaseCost* Mathf.Pow (1.15f,gemLvl)));
			if(gemCostWis == 0 && gemCostChrom == 0){
				gemCostWis = System.Convert.ToUInt64(shadWisBaseCost);
				gemCostChrom = System.Convert.ToUInt64(shadWisBaseCost);
			}
		} else if (classSelected == "Ranger") {
			gemCostWis = System.Convert.ToUInt64(Mathf.Round ( rangWisBaseCost* Mathf.Pow (1.15f,gemLvl)));
			gemCostChrom = System.Convert.ToUInt64(Mathf.Round ( rangChromBaseCost* Mathf.Pow (1.15f,gemLvl)));
			if(gemCostWis == 0 && gemCostChrom == 0){
				gemCostWis = System.Convert.ToUInt64(rangWisBaseCost);
				gemCostChrom = System.Convert.ToUInt64(rangChromBaseCost);
			}
		}else if(classSelected == "Duelist"){
			gemCostWis = System.Convert.ToUInt64(Mathf.Round ( duelWisBaseCost* Mathf.Pow (1.15f,gemLvl)));
			gemCostChrom = System.Convert.ToUInt64(Mathf.Round ( duelChromBaseCost* Mathf.Pow (1.15f,gemLvl)));
			if(gemCostWis == 0 && gemCostChrom == 0){
				gemCostWis = System.Convert.ToUInt64(duelWisBaseCost);
				gemCostChrom = System.Convert.ToUInt64(duelChromBaseCost);
			}
		}else if(classSelected == "Scion"){
			gemCostWis = System.Convert.ToUInt64(Mathf.Round ( scioWisBaseCost* Mathf.Pow (1.15f,gemLvl)));
			gemCostChrom = System.Convert.ToUInt64(Mathf.Round ( scioChromBaseCost* Mathf.Pow (1.15f,gemLvl)));
			if(gemCostWis == 0 && gemCostChrom == 0){
				gemCostWis = System.Convert.ToUInt64(scioWisBaseCost);
				gemCostChrom = System.Convert.ToUInt64(scioChromBaseCost);
			}
		}

	}

	public void DisplayGems(){
		if (classSelected == "Marauder") {
			skillImage.sprite = MaraSprite;
			gemName.text = gemMara + "\nDamage: " +maraDPS + "\nLevel: " + gemLvl +"\nAtt Interval: " +maraAttInt + " s";
		} else if (classSelected == "Templar") {
			skillImage.sprite = TempSprite;
			gemName.text = gemTemp + "\nDPS: " +tempDPS + "\nLevel: " + gemLvl +"\nAtt Interval: " +tempAttInt + " s";
		} else if (classSelected == "Witch") {
			skillImage.sprite = WitcSprite;
			gemName.text = gemWitc + "\nDPS: " +witcDPS + "\nLevel: " + gemLvl +"\nAtt Interval: " +witchAttInt + " s";
		} else if (classSelected == "Shadow") {
			skillImage.sprite = ShadSprite;
			gemName.text = gemShad + "\nDPS: " +shadDPS + "\nLevel: " + gemLvl +"\nAtt Interval: " +shadAttInt + " s";
		} else if (classSelected == "Ranger") {
			skillImage.sprite = RangSprite;
			gemName.text = gemRang + "\nDPS: " +rangDPS + "\nLevel: " + gemLvl +"\nAtt Interval: " +rangAttInt + " s";
		}else if(classSelected == "Duelist"){
			skillImage.sprite = DuelSprite;
			gemName.text = gemDuel + "\nDPS: " +duelDPS + "\nLevel: " + gemLvl +"\nAtt Interval: " +duelAttInt + " s";
		}else if(classSelected == "Scion"){
			skillImage.sprite = ScioSprite;
			gemName.text = gemScio + "\nDPS: " +scioDPS + "\nLevel: " + gemLvl +"\nAtt Interval: " +scioAttInt + " s";
		}
	//	gemName.text += "\nAttack time: " + gemTimeAttack;
	}

	public void GemAttack(){
		timer = 0f;
		if (classSelected == "Marauder") {
			dPSToAttack.mCurrentHealth -= (maraDPS);
		} else if (classSelected == "Templar") {
			dPSToAttack.mCurrentHealth -= (tempDPS);
		} else if (classSelected == "Witch") {
			dPSToAttack.mCurrentHealth -= (witcDPS);
		} else if (classSelected == "Shadow") {
			dPSToAttack.mCurrentHealth -= (shadDPS);
		} else if (classSelected == "Ranger") {
			dPSToAttack.mCurrentHealth -= (rangDPS);
		}else if(classSelected == "Duelist"){
			dPSToAttack.mCurrentHealth -= (duelDPS);
		}else if(classSelected == "Scion"){
			dPSToAttack.mCurrentHealth -= (scioDPS);
		}
		dPSToAttack.mHealthSlider.value = float.Parse (dPSToAttack.mCurrentHealth.ToString("F2"));
		dPSToAttack.ismAlive (dPSToAttack.mHealthSlider.value);

	}
}
