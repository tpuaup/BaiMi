using UnityEngine;
using System.Collections;

public class Sun : MonoBehaviour {
    public float speed;
    public ParticleSystem stars;
    public Light moon;

	
	// Update is called once per frame
	void Update ()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, speed * Time.deltaTime);
        stars.transform.RotateAround(Vector3.zero, Vector3.forward, speed * Time.deltaTime);
        moon.transform.RotateAround(Vector3.zero, Vector3.forward, speed * Time.deltaTime);
    }
}
