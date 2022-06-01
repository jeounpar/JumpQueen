using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    private float h, v;
    public float movespeed;

    private SpriteRenderer spr;
    private Animator animator;
    void Start()
    {
        spr = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        h = Input.GetAxisRaw("Horizontal");
        if (h > 0)
        {
            spr.flipX = false;
            animator.SetBool("Running",true);
        }
        else if (h < 0)
        {
            spr.flipX = true;
            animator.SetBool("Running",true);
        }
        else
        {
            animator.SetBool("Running",false);
                
        }

        transform.position += new Vector3(h, 0, 0)*movespeed*Time.smoothDeltaTime;
    }
}
