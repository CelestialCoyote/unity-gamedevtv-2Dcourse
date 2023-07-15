using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
	[SerializeField] float torqueAmount = 15.0f;
	[SerializeField] float boostSpeed = 25.0f;
	[SerializeField] float baseSpeed = 20.0f;

	Rigidbody2D playerRb2D;
	SurfaceEffector2D surfaceEffector2D;
	bool canMove = true;

	void Start()
	{
		playerRb2D = GetComponent<Rigidbody2D>();
		surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
	}

	void Update()
	{
		if (canMove)
		{
			RotatePlayer();
			RespondToBoost();
		}
	}

	void RotatePlayer()
	{
		if (Input.GetKey(KeyCode.LeftArrow))
			playerRb2D.AddTorque(torqueAmount);
		else if (Input.GetKey(KeyCode.RightArrow))
			playerRb2D.AddTorque(-torqueAmount);
	}

	void RespondToBoost()
	{
		if (Input.GetKey(KeyCode.UpArrow))
			surfaceEffector2D.speed = boostSpeed;
		else
			surfaceEffector2D.speed = baseSpeed;
	}

	public void DisableControls()
	{
		canMove = false;
	}
}
