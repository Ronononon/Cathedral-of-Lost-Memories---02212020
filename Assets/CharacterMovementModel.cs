﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovementModel : MonoBehaviour
{
	public float Speed;
	
	private Vector3 m_MovementDirection;

	private Rigidbody2D m_Body;
    // Start is called before the first frame update
    void Awake()
    {
        m_Body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        UpdateMovement();
    }
	void UpdateMovement()
	{
		if(m_MovementDirection == Vector3.zero){
			m_MovementDirection.Normalize();
		}

		

		m_Body.velocity = m_MovementDirection * Speed;


	}


	public void SetDirection(Vector2 direction)
	{
		m_MovementDirection = new Vector3(direction.x, direction.y, 0);
	}

	public Vector3 GetDirection()
	{
		return m_MovementDirection;
	}

	public bool IsMoving()
	{
		return m_MovementDirection != Vector3.zero;
	}

}
