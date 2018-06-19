using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Attenuation_Manager : MonoBehaviour {

	/*
	ATTENUATION SYSTEM
	------------------
	CALCULATE ATTENUATION BASED ON DISTANCE FROM EMITTER

	attenuationShape: shape of the attenuation radius (determine attenuation based on player's relationship between emitter source and edge of volume?)
	attenuationCurve: formula used to determine amount of attenuation (i.e. linear -> y=mx, log -> y=log(x), etc.)

	applyLPF: bool that allows user to apply low pass filter to attenuation
	 */


	public AttenuationProperty attenuationProperty;

	private string attShape;
	private GameObject parentObject;
	private Vector3 parentObjectPosition;
	private SphereCollider attSphere;
	private BoxCollider attCube;
	private CapsuleCollider attCapsule;

	float volumeAfterAttenuation;
	// Use this for initialization
	void Start () {
		Construct();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void Construct()
	{

	} 

	public float CalculateAttenuation()	{ 
		return volumeAfterAttenuation;
	}



}
