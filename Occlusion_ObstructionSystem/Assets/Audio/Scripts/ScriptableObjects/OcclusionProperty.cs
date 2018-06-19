using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "Audio/Occlusion Property")]
public class OcclusionProperty : ScriptableObject {

	//How much to occlude (clamped between 0 and 1)
	public float occlusionValue;
	//How often to calculate value (clamped between 0 and 1)
	public float refreshInterval;


}
