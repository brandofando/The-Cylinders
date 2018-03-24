using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class introScript : MonoBehaviour {

    public Text instructions;
    public float time = 8;
    private float timeElapsed;

    // Use this for initialization
    void Start()
    {
        Destroy(instructions, time);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
