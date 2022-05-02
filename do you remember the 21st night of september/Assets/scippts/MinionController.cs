using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionController : MonoBehaviour
{
    public float speed = 5;
    public float rotationSpeed = 200.0f;
    public float horizontalInput;
    public float verticalInput;
    private float topBound = 30;
    private float lowerBound = -10;
   
    
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        //move minions forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        //rotate minions
        transform.Rotate(Vector3.up, rotationSpeed * horizontalInput * Time.deltaTime);

        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
      

        }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}


