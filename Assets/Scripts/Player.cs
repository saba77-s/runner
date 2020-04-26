﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector2 targetPos;
    public float Yincrement;
    public float speed;
    public float maxHeight;
    public float minHeight;
    public int health = 3;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
            transform.position = targetPos;
        }else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
            transform.position = targetPos;
        }
        
    }
}
