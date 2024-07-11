using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using BigNumber;
using integer128;
public class Currency : MonoBehaviour {
	public static Currency currency;

	public UnityEngine.UI.Text currencyAcquired;
	public string currencyInfo;
	public int currencyctr;
	private BigInteger passer;
	public UnityEngine.UI.Text hoverInfo;
	public GameObject hoverObject;
	Vector3 mousePos;
	GameObject ccHandler;
	CurrencyHandler cHandlerCurrency;
	void Awake(){
		ccHandler = GameObject.FindGameObjectWithTag("Currency");
		cHandlerCurrency = ccHandler.GetComponent<CurrencyHandler>();
		//currencyUpdate ();
	}
	void Update(){
		if (currencyctr == 1) {
			if(cHandlerCurrency.port == null || cHandlerCurrency.port < 0){
				cHandlerCurrency.port = 0;
				passer = cHandlerCurrency.port;
			}else{
				passer = cHandlerCurrency.port;
			}
			currencyAcquired.text = " "+ NumberConvert.Instance.getNumbersIntoString(passer);
		}else if(currencyctr == 2){
			if(cHandlerCurrency.wis == null || cHandlerCurrency.wis <0){
				cHandlerCurrency.wis = 0;
				passer = cHandlerCurrency.wis;
			}else{
				passer = cHandlerCurrency.wis;
			}
			currencyAcquired.text = " "+ NumberConvert.Instance.getNumbersIntoString(passer);
		}else if(currencyctr == 3){
			if(cHandlerCurrency.trans == null || cHandlerCurrency.trans <0){
				cHandlerCurrency.trans = 0;
				passer = cHandlerCurrency.trans;
			}else{
				passer = cHandlerCurrency.trans;
			}
			currencyAcquired.text = " "+ NumberConvert.Instance.getNumbersIntoString(passer);
		}else if(currencyctr == 4){
			if(cHandlerCurrency.aug == null || cHandlerCurrency.aug <0){
				cHandlerCurrency.aug = 0;
				passer = cHandlerCurrency.aug;
			}else{
				passer = cHandlerCurrency.aug;
			}
			currencyAcquired.text = " "+ NumberConvert.Instance.getNumbersIntoString(passer);
		}else if(currencyctr == 5){
			if(cHandlerCurrency.alt == null || cHandlerCurrency.alt <0){
				cHandlerCurrency.alt = 0;
				passer = cHandlerCurrency.alt;
			}else{
				passer = cHandlerCurrency.alt;
			}
			currencyAcquired.text = " "+ NumberConvert.Instance.getNumbersIntoString(passer);
		}else if(currencyctr == 6){
			if(cHandlerCurrency.chance == null || cHandlerCurrency.chance <0){
				cHandlerCurrency.chance = 0;
				passer = cHandlerCurrency.chance;
			}else{
				passer = cHandlerCurrency.chance;
			}
			currencyAcquired.text = " "+ NumberConvert.Instance.getNumbersIntoString(passer);
		}else if(currencyctr == 7){
			if(cHandlerCurrency.alch == null || cHandlerCurrency.alch <0){
				cHandlerCurrency.alch = 0;
				passer = cHandlerCurrency.alch;
			}else{
				passer = cHandlerCurrency.alch;
			}
			currencyAcquired.text = " "+ NumberConvert.Instance.getNumbersIntoString(passer);
		}else if(currencyctr == 8){
			if(cHandlerCurrency.chrom == null || cHandlerCurrency.chrom <0){
				cHandlerCurrency.chrom = 0;
				passer = cHandlerCurrency.chrom;
			}else{
				passer = cHandlerCurrency.chrom;
			}
			currencyAcquired.text = " "+ NumberConvert.Instance.getNumbersIntoString(passer);
		}else if(currencyctr == 9){
			if(cHandlerCurrency.jew == null || cHandlerCurrency.jew < 0){
				cHandlerCurrency.jew = 0;
				passer = cHandlerCurrency.jew;
			}else{
				passer = cHandlerCurrency.jew;
			}
			currencyAcquired.text = " "+ NumberConvert.Instance.getNumbersIntoString(passer);
		}else if(currencyctr == 10){
			if(cHandlerCurrency.fus == null || cHandlerCurrency.fus <0){
				cHandlerCurrency.fus = 0;
				passer = cHandlerCurrency.fus;
			}else{
				passer = cHandlerCurrency.fus;
			}
			currencyAcquired.text = " "+ NumberConvert.Instance.getNumbersIntoString(passer);
		}else if(currencyctr == 11){
			if(cHandlerCurrency.scour == null || cHandlerCurrency.scour < 0){
				cHandlerCurrency.scour = 0;
				passer = cHandlerCurrency.scour;
			}else{
				passer = cHandlerCurrency.scour;
			}
			currencyAcquired.text = " "+ NumberConvert.Instance.getNumbersIntoString(passer);
		}else if(currencyctr == 12){
			if(cHandlerCurrency.regret == null || cHandlerCurrency.regal < 0){
				cHandlerCurrency.regret = 0;
				passer = cHandlerCurrency.regret;
			}else{
				passer = cHandlerCurrency.regret;
			}
			currencyAcquired.text = " "+ NumberConvert.Instance.getNumbersIntoString(passer);
		}else if(currencyctr == 13){
			if(cHandlerCurrency.blessed == null || cHandlerCurrency.blessed < 0){
				cHandlerCurrency.blessed = 0;
				passer = cHandlerCurrency.blessed;
			}else{
				passer = cHandlerCurrency.blessed;
			}
			currencyAcquired.text = " "+ NumberConvert.Instance.getNumbersIntoString(passer);
		}else if(currencyctr == 14){
			if(cHandlerCurrency.armourScrap == null || cHandlerCurrency.armourScrap < 0){
				cHandlerCurrency.armourScrap = 0;
				passer = cHandlerCurrency.armourScrap;
			}else{
				passer = cHandlerCurrency.armourScrap;
			}
			currencyAcquired.text = " "+ NumberConvert.Instance.getNumbersIntoString(passer);
		}else if(currencyctr == 15){
			if(cHandlerCurrency.whetstone == null || cHandlerCurrency.whetstone < 0){
				cHandlerCurrency.whetstone = 0;
				passer = cHandlerCurrency.whetstone;
			}else{
				passer = cHandlerCurrency.whetstone;
			}
			currencyAcquired.text = " "+ NumberConvert.Instance.getNumbersIntoString(passer);
		}else if(currencyctr == 16){
			if(cHandlerCurrency.glassbaubler == null || cHandlerCurrency.glassbaubler < 0){
				cHandlerCurrency.glassbaubler = 0;
				passer = cHandlerCurrency.glassbaubler;
			}else{
				passer = cHandlerCurrency.glassbaubler;
			}
			currencyAcquired.text = " "+ NumberConvert.Instance.getNumbersIntoString(passer);
		}else if(currencyctr == 17){
			if(cHandlerCurrency.GCP == null || cHandlerCurrency.GCP < 0){
				cHandlerCurrency.GCP = 0;
				passer = cHandlerCurrency.GCP;
			}else{
				passer = cHandlerCurrency.GCP;
			}
			currencyAcquired.text = " "+ NumberConvert.Instance.getNumbersIntoString(passer);
		}else if(currencyctr == 18){
			if(cHandlerCurrency.carto == null || cHandlerCurrency.carto < 0){
				cHandlerCurrency.carto = 0;
				passer = cHandlerCurrency.carto;
			}else{
				passer = cHandlerCurrency.carto;
			}
			currencyAcquired.text = " "+ NumberConvert.Instance.getNumbersIntoString(passer);
		}else if(currencyctr == 19){
			if(cHandlerCurrency.chaos == null || cHandlerCurrency.chaos < 0){
				cHandlerCurrency.chaos = 0;
				passer = cHandlerCurrency.chaos;
			}else{
				passer = cHandlerCurrency.chaos;
			}
			currencyAcquired.text = " "+ NumberConvert.Instance.getNumbersIntoString(passer);
		}else if(currencyctr == 20){
			if(cHandlerCurrency.vaal == null || cHandlerCurrency.vaal < 0){
				cHandlerCurrency.vaal = 0;
				passer = cHandlerCurrency.vaal;
			}else{
				passer = cHandlerCurrency.vaal;
			}
			currencyAcquired.text = " "+ NumberConvert.Instance.getNumbersIntoString(passer);
		}else if(currencyctr == 21){
			if(cHandlerCurrency.regal == null || cHandlerCurrency.regal < 0){
				cHandlerCurrency.regal = 0;
				passer = cHandlerCurrency.regal;
			}else{
				passer = cHandlerCurrency.regal;
			}
			currencyAcquired.text = " "+ NumberConvert.Instance.getNumbersIntoString(passer);
		}else if(currencyctr == 22){
			if(cHandlerCurrency.divine == null || cHandlerCurrency.divine < 0){
				cHandlerCurrency.divine = 0;
				passer = cHandlerCurrency.divine;
			}else{
				passer = cHandlerCurrency.divine;
			}
			currencyAcquired.text = " "+ NumberConvert.Instance.getNumbersIntoString(passer);
		}else if(currencyctr == 23){
			if(cHandlerCurrency.exalt == null || cHandlerCurrency.exalt < 0 ){
				cHandlerCurrency.exalt = 0;
				passer = cHandlerCurrency.exalt;
			}else{
				passer = cHandlerCurrency.exalt;
			}
			currencyAcquired.text = " "+ NumberConvert.Instance.getNumbersIntoString(passer);
		}else if(currencyctr == 24){
			if(cHandlerCurrency.mirror == null || cHandlerCurrency.mirror < 0){
				cHandlerCurrency.mirror = 0;
				passer = cHandlerCurrency.mirror;
			}else{
				passer = cHandlerCurrency.mirror;
			}
				currencyAcquired.text = " "+ NumberConvert.Instance.getNumbersIntoString(passer);
		}
	}

	public void onHover(){
		if(hoverObject.activeInHierarchy.Equals(false)){
			hoverObject.SetActive(true);
		}
		mousePos = (Vector3.right * 30) + Input.mousePosition;
		if (currencyctr == 1) {
			//passer = cHandlerCurrency.port;
			hoverInfo.text = currencyInfo;
		}else if(currencyctr == 2){
			//passer = cHandlerCurrency.wis;
			hoverInfo.text = currencyInfo;
		}else if(currencyctr == 3){
			//passer = cHandlerCurrency.trans;
			hoverInfo.text = currencyInfo;
		}else if(currencyctr == 4){
			//passer = cHandlerCurrency.aug;
			hoverInfo.text = currencyInfo;
		}else if(currencyctr == 5){
			//passer = cHandlerCurrency.alt;
			hoverInfo.text = currencyInfo;
		}else if(currencyctr == 6){
			//passer = cHandlerCurrency.chance;
			hoverInfo.text = currencyInfo;
		}else if(currencyctr == 7){
			//passer = cHandlerCurrency.alch;
			hoverInfo.text = currencyInfo;
		}else if(currencyctr == 8){
			//passer = cHandlerCurrency.chrom;
			hoverInfo.text = currencyInfo;
		}else if(currencyctr == 9){
			//passer = cHandlerCurrency.jew;
			hoverInfo.text = currencyInfo;
		}else if(currencyctr == 10){
			//passer = cHandlerCurrency.fus;
			hoverInfo.text = currencyInfo;
		}else if(currencyctr == 11){
			//passer = cHandlerCurrency.scour;
			hoverInfo.text = currencyInfo;
		}else if(currencyctr == 12){
			//passer = cHandlerCurrency.regret;
			hoverInfo.text = currencyInfo;
		}else if(currencyctr == 13){
			passer = cHandlerCurrency.blessed;
			hoverInfo.text = currencyInfo;
		}else if(currencyctr == 14){
			//passer = cHandlerCurrency.armourScrap;
			hoverInfo.text = currencyInfo;
		}else if(currencyctr == 15){
			//passer = cHandlerCurrency.whetstone;
			hoverInfo.text = currencyInfo;
		}else if(currencyctr == 16){
			//passer = cHandlerCurrency.glassbaubler;
			hoverInfo.text = currencyInfo;
		}else if(currencyctr == 17){
			//passer = cHandlerCurrency.GCP;
			hoverInfo.text = currencyInfo;
		}else if(currencyctr == 18){
			//passer = cHandlerCurrency.carto;
			hoverInfo.text = currencyInfo;
		}else if(currencyctr == 19){
			//passer = cHandlerCurrency.chaos;
			hoverInfo.text = currencyInfo;
		}else if(currencyctr == 20){
			//passer = cHandlerCurrency.vaal;
			hoverInfo.text = currencyInfo;
		}else if(currencyctr == 21){
			//passer = cHandlerCurrency.regal;
			hoverInfo.text = currencyInfo;
		}else if(currencyctr == 22){
			//passer = cHandlerCurrency.divine;
			hoverInfo.text = currencyInfo;
		}else if(currencyctr == 23){
			//passer = cHandlerCurrency.exalt;
			hoverInfo.text = currencyInfo;
		}else if(currencyctr == 24){
			//passer = cHandlerCurrency.mirror;
			hoverInfo.text = currencyInfo;
		}
		hoverObject.transform.position = mousePos;
	}

	public void onExit(){
		if(hoverObject.activeInHierarchy.Equals(true)){
			hoverObject.SetActive(false);
		}
	}
	
}
