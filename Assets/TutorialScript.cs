using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialScript : MonoBehaviour
{
    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 20), "Hello World!");
    }
}
