using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csCharacterMove2 : MonoBehaviour {

    public float speed = 3.0f;
    public float gravity = -20.0f;
    public float speed_chage = 1.5f;

    //public bool way3;
    //public bool way2;
    //public bool zigzag;
    //public bool jump;


    CharacterController controller;
    Vector3 velocity;

    enum Dir { left,right,forward,back};
    Dir dir;
    
    enum Line { line1, line2, line3};
    Line line;

    enum Move { way2, way3, zigzag, jump};
    Move move;

	// Use this for initialization
	void Start () {

        dir = Dir.forward;
        line = Line.line2;
        move = Move.way3;
        controller = GetComponent<CharacterController>();
        velocity = Vector3.zero;
    }
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKeyDown(KeyCode.Space))
        {
            this.transform.Translate(new Vector3(0.0f, 5.0f, 0.0f));
        }

        switch(move)
        {
            case Move.way3:
                Way3_Move();
                break;
            case Move.way2:
                //
                break;
            case Move.zigzag:
                ZigZag_Move();
                break;
            case Move.jump:
                Jump_Move();
                break;

            default:
                break;
        }

    }

    void Jump_Move()
    {
        
    }

    void ZigZag_Move()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (dir == Dir.forward)
            {
                //공백
            }

            if (dir == Dir.right)
            {
                transform.Rotate(Vector3.up * -45.0f);
                speed -= speed_chage;
                dir = Dir.forward;
            }

            if (dir == Dir.left)
            {
                transform.Rotate(Vector3.up * 45.0f);
                speed -= speed_chage;
                dir = Dir.forward;
            }

        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (dir == Dir.forward)
            {
                transform.Rotate(Vector3.up * -45.0f);
                speed += speed_chage;
                dir = Dir.left;
            }

            if (dir == Dir.right)
            {
                transform.Rotate(Vector3.up * -90.0f);
                dir = Dir.left;
            }

            if (dir == Dir.left)
            {
                //아무것도 안함
            }

        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (dir == Dir.forward)
            {
                transform.Rotate(Vector3.up * 45.0f);
                speed += speed_chage;
                dir = Dir.right;
            }

            if (dir == Dir.right)
            {
                //공백
            }

            if (dir == Dir.left)
            {
                transform.Rotate(Vector3.up * 90.0f);
                dir = Dir.right;
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

    public void Jump_MoveOn()
    {
        move = Move.jump;
    }

    public void ZigZag_MoveOn()
    {
        move = Move.zigzag;
    }

    public void  Way3_MoveOn()
    {
        //
    }

    public void Way2_MoveOn()
    {
        //
    }
}
