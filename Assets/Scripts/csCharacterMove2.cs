using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csCharacterMove2 : MonoBehaviour {

    public float speed = 3.0f;
    public float gravity = -20.0f;

    CharacterController controller;
    Vector3 velocity;

    enum State { left,right,forward,back};
    State state;

	// Use this for initialization
	void Start () {
        state = State.forward;
        controller = GetComponent<CharacterController>();
        velocity = Vector3.zero;
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (state == State.forward)
            {
                //공백
            }

            if (state == State.right)
            {
                transform.Rotate(Vector3.up * -45.0f);
                speed -= 1.5f;
                state = State.forward;
            }

            if (state == State.left)
            {
                transform.Rotate(Vector3.up * 45.0f);
                speed -= 1.5f;
                state = State.forward;
            }

        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if(state == State.forward)
            {
                transform.Rotate(Vector3.up * -45.0f);
                speed += 1.5f;
                state = State.left;
            }

            if(state == State.right)
            {
                transform.Rotate(Vector3.up * -90.0f);
                state = State.left;
            }

            if(state == State.left)
            {
                //아무것도 안함
            }

        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (state == State.forward)
            {
                transform.Rotate(Vector3.up * 45.0f);
                speed += 1.5f;
                state = State.right;
            }

            if (state == State.right)
            {
                //공백
            }

            if (state == State.left)
            {
                transform.Rotate(Vector3.up * 90.0f);
                state = State.right;
            }
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //점프 추후 고려
        }

    }
}
