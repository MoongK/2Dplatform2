using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour {

    Vector3 startPos;
    Vector3 LeftPos, RightPos;
    Vector3 UpPos, DownPos;
    Vector3 MoveDir;
    float MoveSpeed = 0.5f;
    float rd;

	void Start () {
        rd = Random.Range(0, 3); // 0 -> stop // 1 -> Vertical // 2 -> Horizontal

        startPos = transform.position;

        LeftPos = startPos + Vector3.left * 5f;
        RightPos = startPos + Vector3.right * 5f;

        UpPos = startPos + Vector3.up * 5f;
        DownPos = startPos + Vector3.down * 5f;

        if (rd == 1)
            MoveDir = UpPos - startPos;
        else if (rd == 2)
            MoveDir = LeftPos - startPos;
        else if(rd == 0)
            MoveDir = Vector3.zero;
    }
	
	void Update ()
    {
        if (rd == 1)
            Vmove();
        else if (rd == 2)
            Hmove();

        transform.Translate(MoveDir * MoveSpeed * Time.deltaTime);
	}

    void Vmove()
    {
        if (transform.position.y > UpPos.y)
            MoveDir = DownPos - startPos;
        else if (transform.position.y < DownPos.y)
            MoveDir = UpPos - startPos;
    }

    void Hmove()
    {
        if (transform.position.x < LeftPos.x)
            MoveDir = RightPos - startPos;
        else if (transform.position.x > RightPos.x)
            MoveDir = LeftPos - startPos;
    }
}