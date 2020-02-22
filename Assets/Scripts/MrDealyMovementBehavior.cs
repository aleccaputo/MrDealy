using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MrDealyMovementBehavior : MonoBehaviour
{
    public Rigidbody2D RigidBody;
    public float MoveForce;
    public GameObject Sword;
    public float JumpForceMultiplier;
    float scale;

    // Start is called before the first frame update
    void Start()
    {
        scale = transform.localScale.x;
    }

    void Update()
    {
        Movement();
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Instantiate(Sword, new Vector3(RigidBody.position.x - 5, RigidBody.position.y, 0), new Quaternion());
        }
    }

    private void Movement()
    {
        var force = new Vector2(0, 0);
        if (Input.GetKey(KeyCode.D))
        {
            transform.localScale = new Vector2(scale, transform.localScale.y);
            force += (new Vector2(20, 0));
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.localScale = new Vector2(-scale, transform.localScale.y);
            force += (new Vector2(-20, 0));
        }
        if (Input.GetKey(KeyCode.S))
        {
            RigidBody.AddForce(new Vector2(0, -20));
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // immediate jump
            RigidBody.AddForce(new Vector2(0, 1).normalized * JumpForceMultiplier);
        }
        else
        {

            RigidBody.AddForce(force.normalized * Time.deltaTime * MoveForce);
        }
    }
}
