using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    public Transform Transform;
    public float TrackSpeed;
    public float CameraOffsetY;
    public float CameraOffsetX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        var myLocation = gameObject.transform.position;
        var distance = Vector2.Distance(myLocation, Transform.position);
        var newLocation = Vector2.MoveTowards(myLocation, Transform.position, TrackSpeed * Time.deltaTime * distance);
        var newNewLocation = new Vector3(newLocation.x / CameraOffsetX, newLocation.y / CameraOffsetY, myLocation.z);
        gameObject.transform.position = newNewLocation;
    }
}
