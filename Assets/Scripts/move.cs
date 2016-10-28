using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class move : MonoBehaviour {

    public TextAsset textFile;
    private List<Vector3> route;
    private int i = 0;
    public float offset;
    public float speedKmhr;
	// Use this for initialization
	void Start ()
    {
        route = new List<Vector3>();
        string fullText = textFile.text;
        while (fullText.Length != 0)
        {
            while (fullText.IndexOf("\r") > 0)
            {
                float x = 0, y = 0, z = 0;
                int p1 = 0, p2 = 0;
                p1 = fullText.IndexOf("{") + 1;
                p2 = fullText.IndexOf(",", p1);
                x = float.Parse(fullText.Substring(p1, p2 - p1));

                p1 = p2 + 2;
                p2 = fullText.IndexOf(",", p1);
                y = float.Parse(fullText.Substring(p1, p2 - p1));

                p1 = p2 + 2;
                p2 = fullText.IndexOf("}", p1);
                z = float.Parse(fullText.Substring(p1, p2 - p1));

                route.Add(new Vector3(x, z + offset, y));
                fullText = fullText.Substring(fullText.IndexOf("\n") + 1);
            }

            fullText = fullText.Substring(fullText.IndexOf("\n") + 1);
            
        }
        transform.position = route[i];
    }
	

	void Update ()
    {

        float step = speedKmhr / 3.6f * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, route[i], step);
        if(transform.position != route[i])
            transform.forward = Vector3.Lerp(transform.forward, route[i] - transform.position, 1f);
        if (transform.position == route[i])
        {
            if (i == 100)
                Destroy(transform.gameObject);
            i++;
        }
            
    }
}
