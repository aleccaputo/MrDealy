using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MrDealySwordBehavior : MonoBehaviour
{
    public float AttackForce;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay2D(Collider2D collider)
    {
        if (Input.GetMouseButton(0))
        {
            var targetLocation = collider.transform.position;
            var collisionPoint = gameObject.transform.position;
            var diff = (targetLocation - collisionPoint).normalized * AttackForce;

            var rigidBody = collider.gameObject.GetComponent<Rigidbody2D>();
            rigidBody.AddForce(diff);
        }
    }
}
