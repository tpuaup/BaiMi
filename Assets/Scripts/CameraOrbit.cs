using UnityEngine;
using System.Collections;

public class CameraOrbit : MonoBehaviour {

    public Transform pivot;
    public float speed;

    private Vector3 offset;

	void Start ()
    {
        offset = transform.position - pivot.position;
        transform.LookAt(pivot.position);
	}
	
	void Update ()
    {
        Quaternion rotation = Quaternion.Euler(0, speed, 0);
        Quaternion newRotation = Quaternion.Slerp(transform.rotation, rotation, 1f);
        offset = newRotation * offset;
        transform.position = pivot.position + offset;
        transform.LookAt(pivot.position);
	}
}
