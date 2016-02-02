using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PinSetter : MonoBehaviour
{
	public Text standingDisplay;

	void Update ()
	{
		standingDisplay.text = CountStanding ().ToString ();
	}

	private int CountStanding ()
	{
		int standingCount = 0;

		foreach (Pin pin in GameObject.FindObjectsOfType<Pin> ()) {
			if (pin.IsStanding ()) {
				standingCount++;
			}
		}
		return standingCount;
	}
}
