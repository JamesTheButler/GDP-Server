﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoMovement : MonoBehaviour {
    float speed = 3.0f;
    Vector3 pos;

    void Update() {
        bool canBeMoved = isOnASquare();

        if (Input.GetKey(KeyCode.RightArrow) && canBeMoved)
        {
            pos += Vector3.right;
        }
        else if (Input.GetKey(KeyCode.LeftArrow) && canBeMoved)
        {
            pos += Vector3.left;
        }
        else if (Input.GetKey(KeyCode.UpArrow) && canBeMoved)
        {
            pos += Vector3.forward;
        }
        else if (Input.GetKey(KeyCode.DownArrow) && canBeMoved)
        {
            pos += Vector3.back;
        }
        transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * speed);
    }

    //Checks that the square reached its location
    bool isOnASquare() {
        Vector3 currentPosition = transform.position;
        bool check = (currentPosition.x % 1 == 0 && currentPosition.z % 1 == 0) ? true : false;
        return check;
    }

    public void setPos(Vector3 newPos) {
        pos = newPos;
        transform.position = newPos;
    }
}
