using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private float horizontal;
    public float dir;
    private bool gameOver;
    private int damage;
    private SpriteRenderer sr;
    private Animator anim;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        damage = 0;
        gameOver = false;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!gameOver){
            if(Input.GetKeyDown(KeyCode.UpArrow)){
                rb.AddForce(Vector2.up * 4, ForceMode2D.Impulse);
                anim.SetTrigger("isJump");
            }else if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow)){
                if(Input.GetKey(KeyCode.LeftArrow))
                {
                    dir = -1;
                    sr.flipX = true;
                }else{
                    dir = 1;
                    sr.flipX = false;
                }
                anim.SetBool("isRun",true);
                if(Input.GetKey(KeyCode.UpArrow)) anim.SetBool("isLookUp",true);
                else if(Input.GetKey(KeyCode.DownArrow)) anim.SetBool("isLookDown",true);
                horizontal = Input.GetAxis("Horizontal");
                transform.Translate(Vector3.right * Time.deltaTime * horizontal);
                if(Input.GetKeyDown(KeyCode.Space)){
                    anim.SetTrigger("isFire");
                };
            }else if(Input.GetKeyDown(KeyCode.Space))
            {
                anim.SetTrigger("isFire");
            }else if(Input.GetKey(KeyCode.DownArrow))
            {
                anim.SetBool("isGrounded", true);
            }else{
                anim.SetBool("isRun",false);
                anim.SetBool("isJump",false);
                anim.SetBool("isFire",false);
                anim.SetBool("isLookUp",false);
                anim.SetBool("isLookDown",false);
                anim.SetBool("isGrounded",false);
            }
        }else anim.SetBool("isDead",true);
    }

    void OnCollisionEnter2D(Collision2D col)
    {/*
        if(col.CompareTag("BulletEnemy"))
            if(damage < 4) damage++;
            else gameOver = true;*/
    }
}