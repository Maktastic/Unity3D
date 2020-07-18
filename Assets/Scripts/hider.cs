using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class hider : MonoBehaviour
{
    public Text t;

    void Start()
    {
        Invoke("DisableText", 2f);
        print("Welcome screen is hidden");
    }

    void DisableText()
    {
        t.enabled = false;
    }
}
