using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public float movSpeed = 5F;
    private Animator anim;
    public float x, y;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(transform.right* movSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(transform.right * -1 * movSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(transform.forward * movSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(transform.forward * -1 * movSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(transform.up * movSpeed * Time.deltaTime);
        }
        anim.SetFloat("Velx", x);
        anim.SetFloat("Vely", y);
    }

}

