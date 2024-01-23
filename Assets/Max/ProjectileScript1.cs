using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ProjectileScript : MonoBehaviour
{
    public Rigidbody myRigidbody;
    public float xSpeed = 0.0f; public float ySpeed = 0.0f; public float zSpeed = 0.0f;
    private Vector3 projectileDirection;
    public float speed = 1.0f;    
    
    public void setDirection(Vector3 direction) 
    {
        Debug.Log("Projectile direction set");
        this.projectileDirection = direction;
        updateRigidBody();

    }

    public void setSpeed(float v)
    {
        Debug.Log("Projectile speed set");
        this.speed = v;
        updateRigidBody();

    }
     
    private void updateRigidBody() 
    {
        myRigidbody.velocity = projectileDirection * speed;
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Projectile Spanwed!");
        projectileDirection = new Vector3(xSpeed, ySpeed, zSpeed);
        myRigidbody.velocity = projectileDirection * speed;
        Debug.Log(myRigidbody.velocity);

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Projectile Hit!");
        Destroy(gameObject);
    }
}
