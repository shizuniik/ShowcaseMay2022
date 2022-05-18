using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogletController : MonoBehaviour
{
    [SerializeField] float speedV;
    [SerializeField] float speedH;
    [SerializeField] float force;
    [SerializeField] float forwardForce;
    private int count = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ForwardMovement();
    }

    private void Update()
    {
        HorizontalMovement(); 
        Jump();
    }

    private void HorizontalMovement()
    {
        transform.Translate(Input.GetAxis("Horizontal") * Vector3.right * Time.deltaTime * speedH);
    }

    void ForwardMovement()
    {
        gameObject.GetComponent<Rigidbody>().AddForce(0, 0, forwardForce * Time.deltaTime); 
    }

    private void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            transform.GetComponent<Rigidbody>().AddForce(force * Vector3.up, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(count);
        count++;
    }
}
