using UnityEngine;
using System.Collections;

public class SlideController : MonoBehaviour {

    public GameObject[] slides;
    private int step;
	// Use this for initialization
	void Start ()
    {
        step = 0;
        foreach(GameObject go in slides)
        {
            go.GetComponent<Slide>().gameObject.active = false;
        }
        slides[step].GetComponent<Slide>().gameObject.active = true;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow) && step < slides.Length-1)
        {
            slides[step].GetComponent<Slide>().gameObject.active = false;
            step++;
            slides[step].GetComponent<Slide>().gameObject.active = true;
        }
        else if(Input.GetKeyDown(KeyCode.LeftArrow) && step >0)
        {
            slides[step].GetComponent<Slide>().gameObject.active = false;
            step--;
            slides[step].GetComponent<Slide>().gameObject.active = true;
        }

	}
}
