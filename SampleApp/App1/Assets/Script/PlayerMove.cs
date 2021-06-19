﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float maxSpeed;
    public float jumpPower;
    Rigidbody2D rigid;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            rigid.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            
        
    }

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        rigid.AddForce(Vector2.right * h, ForceMode2D.Impulse);

        if (rigid.velocity.x > maxSpeed) //velocity : rigidbody의 현재 속도
            rigid.velocity = new Vector2(maxSpeed, rigid.velocity.y);

        if (rigid.velocity.x < maxSpeed * (-1)) //velocity : rigidbody의 현재 속도
            rigid.velocity = new Vector2(maxSpeed * (-1), rigid.velocity.y);

        Debug.DrawRay(gameObject.transform.position, Vector3.down, new Color(0, 1, 0));

        RaycastHit2D rayHit = Physics2D.Raycast(rigid.position, Vector3.down, 1, LayerMask.GetMask("Platform"));

        if (rayHit.collider != null)
        {
                Debug.Log(rayHit.collider.name);
        }
            
    }
}
