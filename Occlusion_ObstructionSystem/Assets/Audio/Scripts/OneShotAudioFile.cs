using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneShotAudioFile : MonoBehaviour {

	public AudioClip audioFile;
	AudioSource playback;
	

	//SCRIPT REFERENCES
	private Attenuation_Manager attenuationCalculator;
	private OccManager occlusionCalculator;
	//FINAL AUDIO PROPERTY CALCULATIONS
	float volumeAfterAttenuation;
	float occlusionValue;
	// Use this for initialization

	void Start () {
		playback = GetComponent<AudioSource>();
		attenuationCalculator = GetComponent<Attenuation_Manager>();
		occlusionCalculator = GetComponent<OccManager>();
		InvokeRepeating("Fire", 1, 1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator Delay()
    {

        yield return new WaitForSeconds(1);

    }

	void Fire(){
//		volumeAfterAttenuation = attenuationCalculator.CalculateAttenuation();
//		occlusionValue = occlusionCalculator.CalculateOcclusion(occlusionValue);
		
//		playback.PlayOneShot(audioFile,volumeAfterAttenuation);
//		Debug.Log(volumeAfterAttenuation);
	}

}
