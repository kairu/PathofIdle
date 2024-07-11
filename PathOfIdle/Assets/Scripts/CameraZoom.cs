using UnityEngine;
using System.Collections;

public class CameraZoom : MonoBehaviour {

	public float minFov = 15f;
	public float maxFov = 90f;
	public float sensitivity = 10f;
	public float fov;
	public GameObject passiveActive;
	//public GameObject backPassive;
	void Update () {
		if(passiveActive.activeInHierarchy.Equals(true)){
			//backPassive.transform.position = Camera.main.transform.position;
			float fov = Camera.main.orthographicSize;
			fov += Input.GetAxis("Mouse ScrollWheel") * sensitivity;
			fov = Mathf.Clamp(fov, minFov, maxFov);
			Camera.main.orthographicSize = fov;

		}
	}


}
