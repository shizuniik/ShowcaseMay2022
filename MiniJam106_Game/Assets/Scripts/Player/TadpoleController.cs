using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TadpoleController : MonoBehaviour
{
    [SerializeField] float speedV;
    [SerializeField] float speedH;
    private int count = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        transform.Translate(Input.GetAxis("Vertical") * Vector3.up * Time.deltaTime * speedV);
        transform.Translate(Input.GetAxis("Horizontal") * Vector3.right * Time.deltaTime * speedH);
    }

    private void OnCollisionEnter(Collision collision)
    {
        count++;
        Debug.Log(count);
    }
}
