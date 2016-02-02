using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour
{
	public Vector3 launchVelocity;
	public AudioClip ballSound;
	public bool inPlay = false;

	private Rigidbody rigidBody;
	private AudioSource audioSource;

	void Start ()
	{
		rigidBody = GetComponent<Rigidbody> ();
		audioSource = GetComponent<AudioSource> ();

		audioSource.clip = ballSound;

		rigidBody.useGravity = false;
	}

	public void Launch (Vector3 velocity)
	{
		inPlay = true;

		rigidBody.useGravity = true;
		rigidBody.velocity = velocity;

		audioSource.Play ();
	}
}
