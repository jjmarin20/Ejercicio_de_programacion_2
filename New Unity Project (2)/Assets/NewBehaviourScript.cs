using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            transform.Translate(transform.right * Input.GetAxis("Horizontal") * 8f * Time.deltaTime);
        }
        if (Input.GetAxis("Vertical") != 0)
        {
            transform.Translate(transform.forward * Input.GetAxis("Vertical") * 8f * Time.deltaTime);
        }
    }

}
