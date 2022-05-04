using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float force;
    public GameObject gun;
    public GameObject projectilePrefab;
    public GameObject minionPrefab;
    private Vector3 aim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Instantiate(minionPrefab, transform.position, minionPrefab.transform.rotation);
        }
        Vector3 mousePos = Input.mousePosition;
        mousePos += Camera.main.transform.forward * 25f;
        aim = Camera.main.ScreenToWorldPoint(mousePos);
        if (Input.GetKey(KeyCode.Mouse0))
        {
            gun.transform.LookAt(aim);
            GameObject projectile = Instantiate(projectilePrefab, gun.transform.position, Quaternion.identity);
            projectile.transform.LookAt(aim);
            Rigidbody b = projectile.GetComponent<Rigidbody>();
            b.AddRelativeForce(Vector3.forward * force);
        }
        }
    }
   

