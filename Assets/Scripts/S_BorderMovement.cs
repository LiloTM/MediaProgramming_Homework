using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_BorderMovement : MonoBehaviour
{
    //Movement for the border
    [SerializeField] private float speed;
    private Rigidbody rg;
    void Start()
    {
        rg = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        if (this.transform.position.x < -7.5)
        {
            this.transform.position = new Vector3(-7.5f, transform.position.y, transform.position.z);
            input = new Vector3(0, 0, 0);
        }
        if (this.transform.position.x > 7.5)
        {
            this.transform.position = new Vector3(7.5f, transform.position.y, transform.position.z);
            input = new Vector3(0, 0, 0);
        }
        rg.MovePosition(transform.position + input * Time.deltaTime * speed);
    }
}
