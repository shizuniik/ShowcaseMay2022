using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoofController : MonoBehaviour
{
    [SerializeField] float speed; 

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RoofFall()); 
    }

    IEnumerator RoofFall()
    {
        while(transform.position.y > 0)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.1f, transform.position.z);
            yield return new WaitForSeconds(speed); 
        }
    }
}
