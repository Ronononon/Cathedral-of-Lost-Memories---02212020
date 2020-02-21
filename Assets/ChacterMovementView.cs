using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChacterMovementView : MonoBehaviour
{

	public Animator Animator;

	private CharacterMovementModel m_MovementModel;

    // Start is called before the first frame update
    void Awake()
    {
        m_MovementModel = GetComponent<CharacterMovementModel>();

		if (Animator == null)
		{
			Debug.LogError("Character Animator Not Set Up, Idiot!");
			enabled = false;
		}
    }

    // Update is called once per frame
    void Update()
    {
        UpdateDirection();
		if(Input.GetKey( KeyCode.Space))
		{
			 Animator.SetTrigger("Attack");
		}
    }

	void UpdateDirection()
	{
		Vector3 direction = m_MovementModel.GetDirection();

		if(direction != Vector3.zero)
		{
			Animator.SetFloat("DirectionX", direction.x);
			Animator.SetFloat("DirectionY", direction.y);
		}

		Animator.SetBool("IsMoving", m_MovementModel.IsMoving());
		
		
	}
}
