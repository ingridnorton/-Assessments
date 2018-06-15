﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   public float moveSpeed;
	public float jumpForce;
	private Rigidbody2D myRigidbody;
	public bool grounded;
	public LayerMask whatIsGround;
	private Collider2D myCollider;
	// Use this for initialization
	void Start()
	{
		myRigidbody = GetComponent<Rigidbody2D>();

		myCollider = GetComponent<BoxCollider2D>() as Collider2D;
	}

	// Update is called once per frame
	void Update()
	{
        //Check if grounded is true
		grounded = Physics2D.IsTouchingLayers(myCollider, whatIsGround);

		myRigidbody.velocity = new Vector2(moveSpeed, myRigidbody.velocity.y);


		//Check if the A key is pressed
		if (Input.GetKeyDown(KeyCode.A))
		{if (grounded)
			{myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpForce);
			
			}
		}
	}
}