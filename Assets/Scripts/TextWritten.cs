using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextWritten : MonoBehaviour {
    private Text text;
    
	// Use this for initialization
	void Start ()
    {
        text = GetComponent<Text>();
        StartCoroutine(TextWriteDown());
	}
	

    IEnumerator TextWriteDown()
    {
        int i = 0;
        string str = text.text;
        text.text = string.Empty;
        yield return new WaitForSeconds(2);
        while (i<str.Length)
        {
            text.text += str[i];
            i++;
            yield return new WaitForSeconds(0.05f);
        }
        
    }
}
