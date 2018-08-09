using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour {

    public static int PinCount;
    public Text text;
	// Use this for initialization
	void Start ()
    {
        PinCount = 0;
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        text.text = PinCount.ToString();
	}
    public static int getpincount()
    {
        return PinCount;
    }
}
