using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D theRG;

    public float moveSpeed = 10.0f;

    Animator myAnim;

    public static PlayerController instance;

    public string areaTransitionName;

    Vector3 bottomLeftLimit, topRightLimit;

    public bool canMove = true;

    private void Awake()
    {
        theRG = GetComponent<Rigidbody2D>();
        myAnim = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            if (instance != this)
            {
                // xóa đối tượng được tạo ra khi load lại scene
                Destroy(gameObject);
            }
        }

        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    private void Update()
    {
        if (canMove)
        {
            theRG.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * moveSpeed;
        }
        else
        {
            theRG.velocity = Vector2.zero;
        }
        myAnim.SetFloat("MoveX", theRG.velocity.x);
        myAnim.SetFloat("MoveY", theRG.velocity.y);

        if (Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1 || Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1)
        {
            if (canMove)
            {
                myAnim.SetFloat("LastMoveX", Input.GetAxisRaw("Horizontal"));
                myAnim.SetFloat("LastMoveY", Input.GetAxisRaw("Vertical"));
            }
        }

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, bottomLeftLimit.x, topRightLimit.x), Mathf.Clamp(transform.position.y, bottomLeftLimit.y, topRightLimit.y), transform.position.z);
    }

    public void SetBounds(Vector3 bt, Vector3 tr)
    {
        bottomLeftLimit = bt + new Vector3(0.5f, 0.5f, 0);
        topRightLimit = tr - new Vector3(0.5f, 0.5f, 0);
    }
}
