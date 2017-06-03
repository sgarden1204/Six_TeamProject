using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csCharacterMove2 : MonoBehaviour {

    public float speed = 3.0f;
    public float gravity = -20.0f;
    public float speed_chage = 1.5f;

    public bool way3;
    public bool way2;
    public bool zigzag;


    CharacterController controller;
    Vector3 velocity;

    enum State { left,right,forward,back};
    State state;
    
    enum Line { line1, line2, line3};
    Line line;

	// Use this for initialization
	void Start () {

        way2 = false;
        way3 = true;
        zigzag = false;

        state = State.forward;
        line = Line.line2;
        controller = GetComponent<CharacterController>();
        velocity = Vector3.zero;
    }
	
	// Update is called once per frame
	void Update () {

        if(way3)
        {
            Way3_Move();
        }

        if(way2)
        {

        }

        if(zigzag)
        {
            ZigZag_Move();
        }

    }

    void ZigZag_Move()
    {
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
                speed -= speed_chage;
                state = State.forward;
            }

            if (state == State.left)
            {
                transform.Rotate(Vector3.up * 45.0f);
                speed -= speed_chage;
                state = State.forward;
            }

        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (state == State.forward)
            {
                transform.Rotate(Vector3.up * -45.0f);
                speed += speed_chage;
                state = State.left;
            }

            if (state == State.right)
            {
                transform.Rotate(Vector3.up * -90.0f);
                state = State.left;
            }

            if (state == State.left)
            {
                //아무것도 안함
            }

        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (state == State.forward)
            {
                transform.Rotate(Vector3.up * 45.0f);
                speed += speed_chage;
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

    void Way3_Move()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        //current_position = this.transform.position;

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if(line == Line.line1)
            {
                //왼쪽으로 갈수 없음
                //this.transform.Translate(new Vector3(-5.0f, 0.0f, 0.0f));
                line = Line.line1;
            }

            if (line == Line.line2)
            {
                this.transform.Translate(new Vector3(-5.0f, 0.0f, 0.0f));
                line = Line.line1;
            }

            if (line == Line.line3)
            {
                this.transform.Translate(new Vector3(-5.0f, 0.0f, 0.0f));
                line = Line.line2;
            }
        }

        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            if(line == Line.line3)
            {
                line = Line.line3;
                //오른쪽 이동방지
            }
            if (line == Line.line2)
            {
                this.transform.Translate(new Vector3(+5.0f, 0.0f, 0.0f));
                line = Line.line3;
            }

            if(line == Line.line1)
            {
                Debug.Log("Right!");
                this.transform.Translate(new Vector3(+5.0f, 0.0f, 0.0f));
                line = Line.line2;
            }

        }
    }

    public void ZigZag_MoveOn()
    {
        way3 = false;
        zigzag = true;
        way2 = false;
    }
}
