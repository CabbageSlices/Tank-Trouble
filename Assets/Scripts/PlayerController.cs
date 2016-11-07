using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    private Rigidbody2D rigidBody;

    public float speed;
    public float rotationalSpeed;

    public int joypadNumber = 3;

	// Use this for initialization
	void Start () {
	    
        rigidBody = GetComponent<Rigidbody2D>() as Rigidbody2D;
	}
	
	// Update is called once per frame
	void Update () {
	    
        Vector2 targetVelocity = Vector2.zero;

        if(InputManager.isUpPressed(joypadNumber))
            targetVelocity = transform.up * speed;
        
        if(InputManager.isDownPressed(joypadNumber))
            targetVelocity = -transform.up * speed;

        float rotationalVelocity = 0;
        
        //rotate to left or right
        if(InputManager.isLeftPressed(joypadNumber))
            rotationalVelocity = rotationalSpeed * (InputManager.isDownPressed(joypadNumber) ? -1 : 1);

        if (InputManager.isRightPressed(joypadNumber))
            rotationalVelocity = -rotationalSpeed * (InputManager.isDownPressed(joypadNumber) ? -1 : 1);

        Vector2 velocityChange = targetVelocity - rigidBody.velocity;

        rigidBody.AddForce(velocityChange, ForceMode2D.Impulse);
        rigidBody.angularVelocity = rotationalVelocity;
	}

    
}
