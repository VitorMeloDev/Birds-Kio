using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScrollUI : MonoBehaviour
{

    public RawImage back, front;
    

    // Update is called once per frame
    void Update()
    {
        back.uvRect = new Rect(0.02f * Time.time, 0, 1, 1);
        front.uvRect = new Rect(0.05f * Time.time, 0, 1, 1);
    }
}
