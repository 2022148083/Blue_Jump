using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jump = 8f;

    //play시 Update 함수가 1프레임마다 실행됨
    private void Update()
    {
        if (!GameManager.playerDie)
        {
            if (Input.GetMouseButtonDown(0))
            {
                GetComponent<Rigidbody2D>().velocity = new Vector3(0, jump, 0);

                transform.rotation = Quaternion.Euler(0, 0, 10f);
            }

            transform.Rotate(0, 0, -0.1f);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag.CompareTo("Pipe_Ground") == 0)
        {
            GameManager.playerDie = true;
        }
    }
}
