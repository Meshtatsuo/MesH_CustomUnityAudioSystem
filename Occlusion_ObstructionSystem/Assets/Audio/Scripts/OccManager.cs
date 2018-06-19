using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OccManager : MonoBehaviour {

	
	// Use this for initialization
	void Start () {
		 var playerCamera = GameObject.FindGameObjectWithTag("MainCamera");
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public float CalculateOcclusion(float occlusionVal){
		var playerCamera = GameObject.FindGameObjectWithTag("MainCamera");
		Vector3 playerLocation = playerCamera.transform.position;
		Vector3 traceStart = this.transform.localPosition;

		Physics.Linecast(traceStart, playerLocation, 5);
		Debug.DrawRay(traceStart, playerLocation, Color.green, 10, true);
		Debug.Log(playerLocation);
		return occlusionVal;
	}


}
