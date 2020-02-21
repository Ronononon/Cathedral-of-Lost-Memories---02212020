using System.Collections;
using UnityEngine;

public class CharacterMovementKeyboardControl : CharacterMovementBaseControl
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateDirection();
    }

	void UpdateDirection(){
		Vector2 newDirection = Vector2.zero;

		if(Input.GetKey( KeyCode.W))
		{
			 newDirection.y = 1;
		}

		if(Input.GetKey( KeyCode.S))
		{
			 newDirection.y = -1;
		}

		if(Input.GetKey( KeyCode.A))
		{
			 newDirection.x = -1;
		}

		if(Input.GetKey( KeyCode.D))
		{
			 newDirection.x = 1;
		}

		SetDirection(newDirection);
	}

}
