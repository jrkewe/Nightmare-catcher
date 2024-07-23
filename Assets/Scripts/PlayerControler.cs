using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public GameObject projectile;
    private float projectileOffset = 0.5f; 

    public float speed = 10.0f;


    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Vector3 projectilePosition= new Vector3(transform.position.x, transform.position.y, transform.position.z + projectileOffset);
            Instantiate (projectile, projectilePosition, transform.rotation);   
        }

            float horizontalInput = Input.GetAxis("Horizontal");
            transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * speed);
        
    }
}
