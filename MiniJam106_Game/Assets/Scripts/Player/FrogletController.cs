using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

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

        if(transform.position.y < -1)
        {
            FindObjectOfType<GameManager>().EndGame(); 
        }
    }

    private void HorizontalMovement()
    {
        //transform.Translate(Input.GetAxis("Horizontal") * Vector3.right * Time.deltaTime * speedH);
        gameObject.GetComponent<Rigidbody>().AddForce(Input.GetAxis("Horizontal") * speedH * Time.deltaTime, 0, 0, ForceMode.VelocityChange); 
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
        if(collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log(count);
            count++;
            FindObjectOfType<GameManager>().EndGame();
        }
      
    }
}
