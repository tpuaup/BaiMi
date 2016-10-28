using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Fade : MonoBehaviour {

    public Color beginColor;
    public Color finishColor;
    public float durationTime;

    void OnEnable()
    {
        if (GetComponent<Text>() != null)
        {
            Text t1 = GetComponent<Text>();
            t1.color = beginColor;
        }
        else if (GetComponent<Image>() != null)
        {
            Image img1 = GetComponent<Image>();
            img1.color = beginColor;
        }

        if (durationTime == 0)
            durationTime = 100f;
    }
	
	// Update is called once per frame
	void Update ()
    {
	    if(GetComponent<Text>()!=null)
        {
            Text t1 = GetComponent<Text>();
            t1.color = Color.Lerp(t1.color, finishColor, 1 / durationTime * Time.deltaTime);
        }

        else if (GetComponent<Image>() != null)
        {
            Image img1 = GetComponent<Image>();
            img1.color = Color.Lerp(img1.color, finishColor, 1 / durationTime * Time.deltaTime);
        }
    }
}
