using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float horizontal;
    private Animator anim;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            rb.AddForce(Vector2.up * 4, ForceMode2D.Impulse);
            anim.SetTrigger("isJump");
        }else if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow)){
            horizontal = Input.GetAxis("Horizontal");
            transform.Translate(Vector3.right * Time.deltaTime * horizontal);
            if(Input.GetKey(KeyCode.Space)){
                anim.SetBool("isRun",true);
                anim.SetBool("isFire",true);
            }else anim.SetBool("isRun",true);
        }else if(Input.GetKey(KeyCode.Space)){
            anim.SetBool("isFire",true);
        }else{
            anim.SetBool("isRun",false);
            anim.SetBool("isJump",false);
            anim.SetBool("isFire",false);
        }
    }
}
