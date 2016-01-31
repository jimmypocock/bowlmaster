using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour
{
	public Vector3 launchVelocity;

	private Rigidbody rigidbody;
	private AudioSource audioSource;

	void Start ()
	{
		rigidbody = GetComponent<Rigidbody> ();
		audioSource = GetComponent<AudioSource> ();

		Launch ();
	}

	public void Launch ()
	{
		rigidbody.velocity = launchVelocity;
		audioSource.Play ();
	}
}
