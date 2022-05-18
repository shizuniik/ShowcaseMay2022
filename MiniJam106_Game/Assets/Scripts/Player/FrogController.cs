using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogController : MonoBehaviour
{
    [SerializeField] float speedV;
    [SerializeField] float speedH;
    [SerializeField] float force;

    private bool canJump; 
    private int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        canJump = true; 
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        transform.Translate(Input.GetAxis("Horizontal") * Vector3.right * Time.deltaTime * speedH);

        Jump();
    }

    private void Jump()
    {
        if (Input.GetButtonDown("Jump") && canJump)
        {
            transform.GetComponent<Rigidbody>().AddForce(force * Vector3.up, ForceMode.Impulse);
            canJump = false; 
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Floor"))
        {
            canJump = true; 
        }
        Debug.Log(count);
        count++;
    }
}
