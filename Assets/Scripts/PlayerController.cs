using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizortalInput;
    public float speed = 10.0f;
    public float xRange = 10.0f;
    public GameObject projectile;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        horizortalInput = Input.GetAxis("Horizontal");
        transform.Translate(horizortalInput * speed * Time.deltaTime * Vector3.right);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Launch the projectile
            Instantiate(projectile, transform.position, projectile.transform.rotation);
        }
    }
}
