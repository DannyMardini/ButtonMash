using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    // TODO: Remember to not use KeyCodes in the future.
    public KeyCode updateKey;

    private Text text;
    private int numPresses = 0;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(updateKey)) {
            numPresses++;
            text.text = numPresses.ToString();
        }
    }
}
