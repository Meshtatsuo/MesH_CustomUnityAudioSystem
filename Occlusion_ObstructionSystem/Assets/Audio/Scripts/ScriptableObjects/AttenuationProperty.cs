using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "Audio/Attenuation Property")]
public class AttenuationProperty : ScriptableObject {
	//Attenuation Types
	public enum attenuationShape{sphere, cube, cone, capsule};
	public enum attenuationCurve{Linear, Log, InverseLog};
	public enum lpfCurve{Linear, Log, InverseLog};

	public attenuationShape attShape;
	public attenuationCurve attCurve;
	public lpfCurve lpfCurveType;
	public float attenuationRadius = 50;

	//Cone ATT Properties
	public float innerConeAngle = 30;
	public float outerConeAngle = 50;
	public float coneATTDistance = 35;

	//Cube ATT Properties
	public float cubeATTLength = 50;
	public float cubeATTWidth = 50;
	public float cubeATTHeight = 50;

	//Capsule ATT Properties
	public float capsuleRadius = 10;
	public float capsuleHeight = 30;
	
	//LPF Vars
	public lpfCurve LPFCurve; 
	public bool applyLPF;
}
