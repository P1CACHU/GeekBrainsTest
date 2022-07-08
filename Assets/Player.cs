using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Rigidbody2D _player = GameObject.Find("Circle").GetComponent<Rigidbody2D>();
        
        if (Input.GetKey(KeyCode.LeftArrow))
            _player.AddForce(Vector2.left*0.01f, ForceMode2D.Impulse);
        if (Input.GetKey(KeyCode.RightArrow))
            _player.AddForce(Vector2.right*0.01f, ForceMode2D.Impulse);
        if (Input.GetKey(KeyCode.Space))
            _player.AddForce(Vector2.up*0.05f, ForceMode2D.Impulse);
    }
}
