using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBTNmenu : MonoBehaviour
{
    public Animator meuAnim;
    private bool key = true;

    public void EventClickG()
    {
        key = !key;

        if(key == false)
        {
            meuAnim.Play("MoreGames");
        }

        if(key )
        {
            meuAnim.Play("Inverse");
        }

    }
}
