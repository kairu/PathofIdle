using UnityEngine;
using System.Collections;

public class PassiveRaycastBlocker : MonoBehaviour {

	public void BlockRaycast(){
		this.GetComponent<CanvasGroup> ().blocksRaycasts = true;
	}

	public void UnblockRaycast(){
		this.GetComponent<CanvasGroup> ().blocksRaycasts = false;
	}
}
