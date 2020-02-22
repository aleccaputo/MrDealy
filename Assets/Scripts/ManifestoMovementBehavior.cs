using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManifestoMovementBehavior : MonoBehaviour
{
    private Vector3 pos1;
    private Vector3 pos2;
    public float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        pos1 = new Vector3(gameObject.transform.position.x - 2, gameObject.transform.position.y , gameObject.transform.position.z);
        pos2 = new Vector3(gameObject.transform.position.x + 2, gameObject.transform.position.y, gameObject.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(pos1, pos2, (Mathf.Sin(speed * Time.time) + 1.0f) / 2.0f);
    }
}
