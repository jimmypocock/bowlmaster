using UnityEngine;
using System.Collections;
using System;

public class Pin : MonoBehaviour
{
	public float standingThreshold = 360f;

	public bool IsStanding ()
	{
		Vector3 rotationInEuler = transform.rotation.eulerAngles;

		float tiltInX = Math.Abs (rotationInEuler.x);
		float tiltInZ = Math.Abs (rotationInEuler.z);

		Debug.Log (tiltInX < standingThreshold && tiltInZ < standingThreshold);
		return tiltInX < standingThreshold && tiltInZ < standingThreshold;
	}
}
