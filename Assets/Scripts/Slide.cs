using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Slide : MonoBehaviour {

    public GameObject[] objectsToHide;
    public GameObject[] objectsToDisplay;

	// Use this for initialization
	void Start ()
    {
        //foreach(GameObject go in objectsToHide)
        //{
        //    go.active = false;
        //}

        //foreach (GameObject go in objectsToDisplay)
        //{
        //    go.active = false;
        //}
    }

    void OnEnable()
    {
        foreach (GameObject go in objectsToHide)
        {
            go.active = false;
        }

        foreach (GameObject go in objectsToDisplay)
        {
            go.active = true;
        }
    }
    void OnDisable()
    {
        foreach (GameObject go in objectsToHide)
        {
            go.active = false;
        }

        foreach (GameObject go in objectsToDisplay)
        {
            go.active = true;
        }

    }
	

}
