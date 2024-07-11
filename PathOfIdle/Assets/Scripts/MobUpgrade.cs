using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using BigNumber;
public class MobUpgrade : MonoBehaviour {

	public Sprite sprite;
	public string name;
	public Image image;
	public UnityEngine.UI.Text textName;
	public BigNumber.BigInteger augCost,fusCost;
	public BigNumber.BigInteger _augHandle,_fusHandle;
	//private int _count;

	GameObject getCountMob;
	MobLife gCountMob;
	GameObject getCurrency;
	CurrencyHandler gCurrency;
	void Awake(){
		getCountMob = GameObject.FindGameObjectWithTag ("Enemy");
		gCountMob = getCountMob.GetComponent<MobLife>();
		getCurrency = GameObject.FindGameObjectWithTag ("Currency");
		gCurrency = getCurrency.GetComponent<CurrencyHandler>();
	}
	void Start(){
		DisplayMobs ();
	}

	public void DisplayMobs(){
		image.sprite = sprite;
		textName.text = name;
	}

	public void onPurchase(){
		_augHandle = gCurrency.aug;
		_fusHandle = gCurrency.fus;
		if (_augHandle >= augCost && _fusHandle >= fusCost) {
			gCurrency.aug -= augCost;
			gCurrency.fus -= fusCost;
			gCountMob.mobCount +=1;
			gCountMob.newMob();
			//this.gameObject.SetActive(false);
		}
	}
}
