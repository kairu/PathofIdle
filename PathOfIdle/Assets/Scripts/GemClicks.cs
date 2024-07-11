using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GemClicks : MonoBehaviour {
//	public static GemClicks gemClick;
	public GameObject gemPanel;
	public GameObject currencyWindow;
	public Vector3 temp;
//	private int _switch;
	public GameObject objectToReturnTo;
	private Vector3 _currencyStore;
	private Vector3 _gemStore;

	//GameObject gemTier;
	//GemTierUpg gemTiers;

	void Awake(){
		//gemTier = GameObject.FindGameObjectWithTag ("Currency");
		//gemTiers = gemTier.GetComponent<GemTierUpg> ();
		_currencyStore = objectToReturnTo.transform.position;
		_currencyStore.x = 125;
		_currencyStore.y = Screen.height / 2;
		//_switch = 0;
		//_store = gemTiers.returnToOriginal.transform.position;
		gemPanel.SetActive (false);
	}
	
	public void onGemClick(){
		if (gemPanel.activeInHierarchy.Equals (false)) {
			gemPanel.SetActive (true);
			_gemStore.x = 360;
			//gameObject.GetComponent<Button>().onClick.AddListener
			_gemStore.y = this.transform.position.y;
			gemPanel.transform.position = _gemStore;
			//_switch = 1;
			//Debug.Log(_switch);
		}else {
			currencyWindow.transform.position = _currencyStore;
			if(gemPanel.activeInHierarchy.Equals(true)){
				gemPanel.SetActive (false);
			}
			if(currencyWindow.activeInHierarchy.Equals(true)){
				currencyWindow.SetActive(false);
			}
			//_switch = 0;
		//	gemTiers._switch = 0;
			//Debug.Log(_switch);
		}
		/*if(gemPanel.activeSelf.Equals(false)){
			_switch = 1;
		}*/
	}
	

}
