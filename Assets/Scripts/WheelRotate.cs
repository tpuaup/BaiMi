using UnityEngine;
using System.Collections;

public class WheelRotate : MonoBehaviour {

    private MeshRenderer mr;
    public Transform center;

    void Start()
    {
        mr = GetComponent<MeshRenderer>();
    }
	// Update is called once per frame
	void Update ()
    {
        if(!center)
            transform.RotateAround(mr.bounds.center, transform.right, 20f);
        else
            transform.RotateAround(center.position, center.right, 20f);

    }
}
