using UnityEngine;
using System.Collections;


[RequireComponent (typeof(Ball))]
public class DragLaunch : MonoBehaviour
{
	private Ball ball;
	private Vector3 dragStart, dragEnd;
	private float timeStart, timeEnd;

	void Start ()
	{
		ball = GetComponent<Ball> ();
	}

	public void MoveStart (float amount)
	{
		if (!ball.inPlay) {
			ball.transform.Translate (amount, 0, 0);
		}
	}

	public void DragStart ()
	{	// Capture time and position of mouse
		dragStart = Input.mousePosition;
		timeStart = Time.time;

	}

	public void DragEnd ()
	{	// Launch ball
		dragEnd = Input.mousePosition;
		timeEnd = Time.time;

		float dragDuration = timeStart - timeEnd;

		float launchSpeedX = (dragStart.x - dragEnd.x) / dragDuration;
		float launchSpeedZ = (dragStart.y - dragEnd.y) / dragDuration;

		Vector3 launchVelocity = new Vector3 (launchSpeedX, 0, launchSpeedZ);
		ball.Launch (launchVelocity);
	}
}
