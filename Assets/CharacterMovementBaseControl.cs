using System.Collections;
using UnityEngine;

public class CharacterMovementBaseControl : MonoBehaviour
{
	protected CharacterMovementModel m_MovementModel;

	void Awake()
	{
		m_MovementModel = GetComponent<CharacterMovementModel>();
	}

	protected void SetDirection(Vector2 direction){
		m_MovementModel.SetDirection(direction);
	}




}
