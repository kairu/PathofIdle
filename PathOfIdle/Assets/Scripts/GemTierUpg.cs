using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GemTierUpg : MonoBehaviour {
	public UnityEngine.UI.Text displayer;
	public GameObject idleHide;
	public int maraBlue, tempBlue, witcBlue, shadBlue, rangBlue, duelBlue, scioBlue; // %rate to Blue
	public int maraRare, tempRare, witcRare, shadRare, rangRare, duelRare, scioRare; // %rate to Rare
	public int maraUnique, tempUnique, witcUnique, shadUnique, rangUnique, duelUnique, scioUnique; //%rate to Unique
	public ulong maraGCPCost,tempGCPCost,witcGCPCost,shadGCPCost,rangGCPCost,duelGCPCost,scioGCPCost; // GCP to Upgrade Cost
	public int isWhite,isBlue, isRare, isUnique;
	int _convertRate;
	float _convertToFloat;
	private Vector3 mousePos;
	public Color Affordable;
	public Color Broke;
	GameObject getGCP;
	CurrencyHandler takeGCP;
	//GameObject getGCPCost;
	//SkillGems this.GetComponentInParent<SkillGems>();
	void Awake(){
		getGCP = GameObject.FindGameObjectWithTag ("Currency");
		takeGCP = getGCP.GetComponent<CurrencyHandler>();
		//getGCPCost = GameObject.FindGameObjectWithTag ("IdleGems");
		//this.GetComponentInParent<SkillGems>() = getGCPCost.GetComponent<SkillGems>();
		//if (idleHide.activeInHierarchy.Equals(true)) {
			//idleHide.SetActive(false);
		//}
	}
	void Start(){
		maraGCPCost = 100;
		tempGCPCost = 100;
		witcGCPCost = 100;
		shadGCPCost = 100;
		rangGCPCost = 100;
		duelGCPCost = 100;
		scioGCPCost = 100;
	}
	void Update(){
		if(ulong.Parse(takeGCP.GCP.ToString()) >= maraGCPCost){
			GetComponent<Image>().color = Affordable;
		}else{
			GetComponent<Image>().color = Broke;
		}
	}

	public void onHover(){
		if(idleHide.activeInHierarchy.Equals(false)){
		idleHide.SetActive (true);
		}
		mousePos = (Vector3.right * 30) + Input.mousePosition;
		idleHide.transform.position = mousePos;
		if (Status.stats.classSelected == "Marauder") {
			displayer.text = "GemCutter Cost: "+maraGCPCost + "\nSuccess Rate: ";
			if(isBlue == 1 && isRare == 0){
				displayer.text += "" +maraRare + "%";
			}else if(isRare == 1 && isBlue == 1 && isUnique == 0){
				displayer.text += "" +maraUnique + "%";
			}else if(isUnique == 1 && isRare == 1 && isBlue == 1){
				displayer.text = "Max Tier";
			}else{
				displayer.text += "" +maraBlue + "%";
			}
		}else if(Status.stats.classSelected == "Templar"){
			displayer.text = "GemCutter Cost: "+tempGCPCost + "\nSuccess Rate: " +tempBlue;
			if(isBlue == 1 && isRare == 0){
				displayer.text += "" +tempRare + "%";
			}else if(isRare == 1 && isBlue == 1 && isUnique == 0){
				displayer.text += "" +tempUnique + "%";
			}else if(isUnique == 1 && isRare == 1 && isBlue == 1){
				displayer.text = "Max Tier";
			}else{
				displayer.text += "" +tempBlue + "%";
			}
		}else if(Status.stats.classSelected == "Witch"){
			displayer.text = "GemCutter Cost: "+witcGCPCost + "\nSuccess Rate: " +witcBlue;
			if(isBlue == 1 && isRare == 0){
				displayer.text += "" +witcRare + "%";
			}else if(isRare == 1  && isBlue == 1 && isUnique == 0){
				displayer.text += "" +witcUnique + "%";
			}else if(isUnique == 1 && isRare == 1 && isBlue == 1){
				displayer.text = "Max Tier";
			}else{
				displayer.text += "" +witcBlue + "%";
			}
		}else if(Status.stats.classSelected == "Shadow"){
			displayer.text = "GemCutter Cost: "+shadGCPCost + "\nSuccess Rate: " + shadBlue;
			if(isBlue == 1 && isRare == 0){
				displayer.text += "" +shadRare + "%";
			}else if(isRare == 1  && isBlue == 1 && isUnique == 0){
				displayer.text += "" +shadUnique + "%";
			}else if(isUnique == 1 && isRare == 1 && isBlue == 1){
				displayer.text = "Max Tier";
			}else{
				displayer.text += "" +shadBlue + "%";
			}
		}else if(Status.stats.classSelected == "Ranger"){
			displayer.text = "GemCutter Cost: "+rangGCPCost + "\nSuccess Rate: " + rangBlue;
			if(isBlue == 1 && isRare == 0){
				displayer.text += "" +rangRare + "%";
			}else if(isRare == 1  && isBlue == 1 && isUnique == 0){
				displayer.text += "" +rangUnique + "%";
			}else if(isUnique == 1 && isRare == 1 && isBlue == 1){
				displayer.text = "Max Tier";
			}else{
				displayer.text += "" +rangBlue + "%";
			}
		}else if(Status.stats.classSelected == "Duelist"){
			displayer.text = "GemCutter Cost: "+duelGCPCost + "\nSuccess Rate: " + duelBlue;
			if(isBlue == 1 && isRare == 0){
				displayer.text += "" +duelRare + "%";
			}else if(isRare == 1  && isBlue == 1 && isUnique == 0){
				displayer.text += "" +duelUnique + "%";
			}else if(isUnique == 1 && isRare == 1 && isBlue == 1){
				displayer.text = "Max Tier";
			}else{
				displayer.text += "" +duelBlue + "%";
			}
		}else if(Status.stats.classSelected == "Scion"){
			displayer.text = "GemCutter Cost: "+scioGCPCost + "\nSuccess Rate: " + scioBlue;
			if(isBlue == 1 && isRare == 0){
				displayer.text += "" +scioRare + "%";
			}else if(isRare == 1  && isBlue == 1 && isUnique == 0){
				displayer.text += "" +scioUnique + "%";
			}else if(isUnique == 1 && isRare == 1 && isBlue == 1){
				displayer.text = "Max Tier";
			}else{
				displayer.text += "" +scioBlue + "%";
			}
		}
	}

	public void onExit(){
		idleHide.SetActive (false);
	}

	public void onClick(){
		if (Status.stats.classSelected == "Marauder") {
			if (takeGCP.GCP >= System.Convert.ToUInt32(maraGCPCost)) {
				if(isBlue == 1 && isRare == 0){
					_convertToFloat = float.Parse((float.Parse((float.Parse(maraRare.ToString())/100).ToString("F2")) *1000).ToString());
					//_convertToFloat = _convertToFloat*1000;
					_convertRate = int.Parse(_convertToFloat.ToString());
				}else if(isRare == 1 && isUnique == 0 && isBlue == 1){
					_convertToFloat = float.Parse((float.Parse((float.Parse(maraUnique.ToString())/100).ToString("F2")) *1000).ToString());
					_convertRate = int.Parse(_convertToFloat.ToString());
				}else{
					_convertToFloat = float.Parse((float.Parse((float.Parse(maraBlue.ToString())/100).ToString("F2")) *1000).ToString());
					_convertRate = int.Parse(_convertToFloat.ToString());
				}
				takeGCP.GCP -= System.Convert.ToUInt32(maraGCPCost);
				chanceToUpg();
			}
		}else if(Status.stats.classSelected == "Templar"){
			if(takeGCP.GCP >=System.Convert.ToUInt32(tempGCPCost)){
				if(isBlue == 1 && isRare == 0){
					_convertToFloat = float.Parse((float.Parse((float.Parse(tempRare.ToString())/100).ToString("F2")) *1000).ToString());
					//_convertToFloat = _convertToFloat*1000;
					_convertRate = int.Parse(_convertToFloat.ToString());
				}else if(isRare == 1 && isUnique == 0 && isBlue == 1){
					_convertToFloat = float.Parse((float.Parse((float.Parse(tempUnique.ToString())/100).ToString("F2")) *1000).ToString());
					_convertRate = int.Parse(_convertToFloat.ToString());
				}else{
					_convertToFloat = float.Parse((float.Parse((float.Parse(tempBlue.ToString())/100).ToString("F2")) *1000).ToString());
					_convertRate = int.Parse(_convertToFloat.ToString());
				}
				takeGCP.GCP -= System.Convert.ToUInt32(maraGCPCost);
				chanceToUpg();
			}
		}else if(Status.stats.classSelected == "Witch"){
			if(takeGCP.GCP >= System.Convert.ToUInt32(witcGCPCost)){
				if(isBlue == 1 && isRare == 0){
					_convertToFloat = float.Parse((float.Parse((float.Parse(witcRare.ToString())/100).ToString("F2")) *1000).ToString());
					//_convertToFloat = _convertToFloat*1000;
					_convertRate = int.Parse(_convertToFloat.ToString());
				}else if(isRare == 1 && isUnique == 0 && isBlue == 1){
					_convertToFloat = float.Parse((float.Parse((float.Parse(witcUnique.ToString())/100).ToString("F2")) *1000).ToString());
					_convertRate = int.Parse(_convertToFloat.ToString());
				}else{
					_convertToFloat = float.Parse((float.Parse((float.Parse(witcBlue.ToString())/100).ToString("F2")) *1000).ToString());
					_convertRate = int.Parse(_convertToFloat.ToString());
				}
				takeGCP.GCP -= System.Convert.ToUInt32(maraGCPCost);
				chanceToUpg();
			}
		}else if(Status.stats.classSelected == "Shadow"){
					if(takeGCP.GCP >= System.Convert.ToUInt32(shadGCPCost)){
				if(isBlue == 1 && isRare == 0){
					_convertToFloat = float.Parse((float.Parse((float.Parse(shadRare.ToString())/100).ToString("F2")) *1000).ToString());
					//_convertToFloat = _convertToFloat*1000;
					_convertRate = int.Parse(_convertToFloat.ToString());
				}else if(isRare == 1 && isUnique == 0 && isBlue == 1){
					_convertToFloat = float.Parse((float.Parse((float.Parse(shadUnique.ToString())/100).ToString("F2")) *1000).ToString());
					_convertRate = int.Parse(_convertToFloat.ToString());
				}else{
					_convertToFloat = float.Parse((float.Parse((float.Parse(shadBlue.ToString())/100).ToString("F2")) *1000).ToString());
					_convertRate = int.Parse(_convertToFloat.ToString());
				}
						takeGCP.GCP -= System.Convert.ToUInt32(maraGCPCost);
				chanceToUpg();
			}
		}else if(Status.stats.classSelected == "Ranger"){
					if(takeGCP.GCP >= System.Convert.ToUInt32(rangGCPCost)){
				if(isBlue == 1 && isRare == 0){
					_convertToFloat = float.Parse((float.Parse((float.Parse(rangRare.ToString())/100).ToString("F2")) *1000).ToString());
					//_convertToFloat = _convertToFloat*1000;
					_convertRate = int.Parse(_convertToFloat.ToString());
				}else if(isRare == 1 && isUnique == 0 && isBlue == 1){
					_convertToFloat = float.Parse((float.Parse((float.Parse(rangUnique.ToString())/100).ToString("F2")) *1000).ToString());
					_convertRate = int.Parse(_convertToFloat.ToString());
				}else{
					_convertToFloat = float.Parse((float.Parse((float.Parse(rangBlue.ToString())/100).ToString("F2")) *1000).ToString());
					_convertRate = int.Parse(_convertToFloat.ToString());
				}
						takeGCP.GCP -= System.Convert.ToUInt32(maraGCPCost);
				chanceToUpg();
			}
		}else if(Status.stats.classSelected == "Duelist"){
					if(takeGCP.GCP >= System.Convert.ToUInt32(duelGCPCost)){
				if(isBlue == 1 && isRare == 0){
					_convertToFloat = float.Parse((float.Parse((float.Parse(duelRare.ToString())/100).ToString("F2")) *1000).ToString());
					//_convertToFloat = _convertToFloat*1000;
					_convertRate = int.Parse(_convertToFloat.ToString());
				}else if(isRare == 1 && isUnique == 0 && isBlue == 1){
					_convertToFloat = float.Parse((float.Parse((float.Parse(duelUnique.ToString())/100).ToString("F2")) *1000).ToString());
					_convertRate = int.Parse(_convertToFloat.ToString());
				}else{
					_convertToFloat = float.Parse((float.Parse((float.Parse(duelBlue.ToString())/100).ToString("F2")) *1000).ToString());
					_convertRate = int.Parse(_convertToFloat.ToString());
				}
						takeGCP.GCP -= System.Convert.ToUInt32(maraGCPCost);
				chanceToUpg();
			}
		}else if(Status.stats.classSelected == "Scion"){
			if(takeGCP.GCP >= System.Convert.ToUInt32(scioGCPCost)){
				if(isBlue == 1 && isRare == 0){
					_convertToFloat = float.Parse((float.Parse((float.Parse(scioRare.ToString())/100).ToString("F2")) *1000).ToString());
					//_convertToFloat = _convertToFloat*1000;
					_convertRate = int.Parse(_convertToFloat.ToString());
				}else if(isRare == 1 && isUnique == 0 && isBlue == 1){
					_convertToFloat = float.Parse((float.Parse((float.Parse(scioUnique.ToString())/100).ToString("F2")) *1000).ToString());
					_convertRate = int.Parse(_convertToFloat.ToString());
				}else{
					_convertToFloat = float.Parse((float.Parse((float.Parse(scioBlue.ToString())/100).ToString("F2")) *1000).ToString());
					_convertRate = int.Parse(_convertToFloat.ToString());
				}
				takeGCP.GCP -= System.Convert.ToUInt32(maraGCPCost);
				chanceToUpg();
			}
		}
			

		onHover ();
	}
	// cost = Mathf.Round(baseCost * Mathf.Pow(1.15f,count));
	public void chanceToUpg(){
			if(Random.Range(0,1000) <= _convertRate){
				if(isBlue == 0 && isWhite == 0){
					isBlue = 1;
					if(Status.stats.classSelected == "Marauder"){
						maraGCPCost = maraGCPCost * 5;
					}else if(Status.stats.classSelected == "Templar"){
			
					}else if(Status.stats.classSelected == "Witch"){
			
					}else if(Status.stats.classSelected == "Shadow"){
				
					}else if(Status.stats.classSelected == "Ranger"){
				
					}else if(Status.stats.classSelected == "Duelist"){
				
					}else if(Status.stats.classSelected == "Scion"){
			
					}	
					//Debug.Log(isBlue);
				}else if(isBlue == 1 && isRare == 0){
					isRare = 1;
					if(Status.stats.classSelected == "Marauder"){
						maraGCPCost = maraGCPCost * 20;
					}else if(Status.stats.classSelected == "Templar"){
						
					}else if(Status.stats.classSelected == "Witch"){
						
					}else if(Status.stats.classSelected == "Shadow"){
						
					}else if(Status.stats.classSelected == "Ranger"){
						
					}else if(Status.stats.classSelected == "Duelist"){
						
					}else if(Status.stats.classSelected == "Scion"){
						
					}
				}else if(isBlue == 1 && isRare == 1 && isUnique == 0){
					isUnique = 1;
					if(Status.stats.classSelected == "Marauder"){
						maraGCPCost = maraGCPCost * 50;
					}else if(Status.stats.classSelected == "Templar"){
						
					}else if(Status.stats.classSelected == "Witch"){
						
					}else if(Status.stats.classSelected == "Shadow"){
						
					}else if(Status.stats.classSelected == "Ranger"){
						
					}else if(Status.stats.classSelected == "Duelist"){
						
					}else if(Status.stats.classSelected == "Scion"){
						
					}
				}
			this.GetComponentInParent<SkillGems>().RankUp();
			}
		//Debug.Log (_convertRate);
	}
	/*public static GemTierUpg gemTier;
	//public GameObject currencyPanel;
	//public GameObject returnToOriginal;
	public GameObject currencyWindow;
	public GameObject objectToReturnTo;
	//public GameObject gemUpgradeWindow;
	public GameObject anchor;
	public Vector3 temp;
	//public int _switch;
	//public Vector3 tempAnchor;
	private Vector3 _storeObject;
	
	//GameObject gemSwitch;
	//GemClicks gemSwitcher;

	void Awake(){
		//gemSwitch = GameObject.FindGameObjectWithTag ("SkillGems");
		//gemSwitcher = gemSwitch.GetComponent<GemClicks>();
		//temp = gemUpgradeWindow.transform.position;
		_storeObject = objectToReturnTo.transform.position;
		_storeObject.x = 125;
		_storeObject.y = Screen.height / 2; 
		//tempAnchor = anchor.transform.position;
		temp = currencyWindow.transform.position;
		//returnToOriginal.transform.position = currencyPanel.transform.position;
		//Debug.Log (returnToOriginal.transform.position);
		//_switch = 0;
		//switchGet._switch = _switch;
		//_switch = GemClicks.gemClick._switch;
	}

	public void gemCraft(){
		if (currencyWindow.activeInHierarchy.Equals(false)) {
		
			currencyWindow.gameObject.SetActive (true);
			temp.x = anchor.transform.position.x + 273;
			//temp.x =(Screen.width/2) + 90;
			temp.y = Screen.height / 2;
			currencyWindow.transform.position = temp;
			//_switch = 1;
			//GemClicks.gemClick._switch = _switch;
			//Debug.Log(_switch);
		} else {
			currencyWindow.transform.position = _storeObject;
			currencyWindow.gameObject.SetActive (false);
			//_switch = 0;
			//GemClicks.gemClick._switch = _switch;
			//Debug.Log(_switch);
		}
	}*/

}
