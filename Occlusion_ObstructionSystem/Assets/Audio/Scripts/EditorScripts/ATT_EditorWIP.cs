using System;
using UnityEngine;
using UnityEditor;
/*
[CustomEditor(typeof(Attenuation_Manager))]
[CanEditMultipleObjects]

public class Attenuation_ManagerEditor : Editor {

	override public void OnInspectorGUI()
	{
		var attTools = target as Attenuation_Manager;

		attTools.hideBool = EditorGUILayout.Toggle(("Hide All"), attTools.hideBool);

		using (var allgroup = new EditorGUILayout.FadeGroupScope(Convert.ToSingle(attTools.hideBool)))
		{
			if (allgroup.visible == false)
			{
				EditorGUI.indentLevel++;
				EditorGUILayout.PrefixLabel("Attenuation Properties");
				EditorGUI.indentLevel++;
				//ATTENUATION CENTER/STARTPOINT
				EditorGUILayout.BeginHorizontal();
				EditorGUILayout.LabelField("Attenuation Centerpoint");
				EditorGUILayout.Vector3Field("",attTools.attCenterLoc);
				EditorGUILayout.EndHorizontal();
				//ATTENUATION FORWARD VECTOR
				EditorGUILayout.BeginHorizontal();
				EditorGUILayout.LabelField("Forward Vector");
				EditorGUILayout.Vector3Field("",attTools.rotationVector);
				EditorGUILayout.EndHorizontal();
				//ATTENUATION SHAPE FIELDS
				EditorGUILayout.BeginHorizontal();
				EditorGUILayout.LabelField("Attenuation Shape");
				EditorGUILayout.EnumFlagsField(attTools.attShape);
				EditorGUILayout.EndHorizontal();
				//ATTENUATION SHAPE PROPERTIES (DISPLAYED BASED ON SHAPE SELECT)
				EditorGUI.indentLevel++;
				//Sphere
					EditorGUILayout.BeginHorizontal();
					EditorGUILayout.LabelField("Attenuation Radius");
					EditorGUILayout.FloatField(attTools.attenuationRadius);
					EditorGUILayout.EndHorizontal();
				//Cube
					//Cube Length
					EditorGUILayout.BeginHorizontal();
					EditorGUILayout.LabelField("Attenuation Cube Length");
					EditorGUILayout.FloatField(attTools.cubeATTLength);
					EditorGUILayout.EndHorizontal();
					//Cube Width				
					EditorGUILayout.BeginHorizontal();
					EditorGUILayout.LabelField("Attenuation Cube Width");
					EditorGUILayout.FloatField(attTools.cubeATTWidth);
					EditorGUILayout.EndHorizontal();				
					//Cube Height				
					EditorGUILayout.BeginHorizontal();
					EditorGUILayout.LabelField("Attenuation Cube Height");
					EditorGUILayout.FloatField(attTools.cubeATTHeight);
					EditorGUILayout.EndHorizontal();
				//Cone
					//Inner Cone Angle
					EditorGUILayout.BeginHorizontal();
					EditorGUILayout.LabelField("Inner Cone Angle");
					EditorGUILayout.FloatField(attTools.innerConeAngle);
					EditorGUILayout.EndHorizontal();
					//Outer Cone Angle
					EditorGUILayout.BeginHorizontal();
					EditorGUILayout.LabelField("Outer Cone Angle");
					EditorGUILayout.FloatField(attTools.outerConeAngle);
					EditorGUILayout.EndHorizontal();
					//Cone distance
					EditorGUILayout.BeginHorizontal();
					EditorGUILayout.LabelField("Attenuation Distance");
					EditorGUILayout.FloatField(attTools.coneATTDistance);
					EditorGUILayout.EndHorizontal();
				//Capsule
					//Capsule Radius
					EditorGUILayout.BeginHorizontal();
					EditorGUILayout.LabelField("Capsule Radius");
					EditorGUILayout.FloatField(attTools.capsuleRadius);
					EditorGUILayout.EndHorizontal();
					//Capsule Height
					EditorGUILayout.BeginHorizontal();
					EditorGUILayout.LabelField("Capsule Height");
					EditorGUILayout.FloatField(attTools.capsuleHeight);
					EditorGUILayout.EndHorizontal();
				EditorGUI.indentLevel--;
				//ATTENUATION CURVE FIELDS
				EditorGUILayout.BeginHorizontal();
				EditorGUILayout.LabelField("Attenuation Curve");
				EditorGUILayout.EnumFlagsField(attTools.attCurve);
				EditorGUILayout.EndHorizontal();
				//APPLY LPF FIELDS
				EditorGUILayout.BeginHorizontal();
				EditorGUILayout.LabelField("Attenuate with LPF");
				EditorGUILayout.Toggle(attTools.applyLPF);
				EditorGUILayout.EndHorizontal();
				EditorGUI.indentLevel++;
					//LPF Curve Selection
					EditorGUILayout.BeginHorizontal();
					EditorGUILayout.LabelField("LPF Curve");
					EditorGUILayout.EnumFlagsField(attTools.LPFCurve);
					EditorGUILayout.EndHorizontal();
				EditorGUI.indentLevel--;
				//

			}//end if visible
		}//end new fade group

	}

}

*/