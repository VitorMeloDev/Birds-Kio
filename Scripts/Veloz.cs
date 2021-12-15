using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Veloz : MonoBehaviour
{

    public Rigidbody2D meuRB;
    public bool libera = false;
    public int trava = 0;
    private Touch touch;
    // Start is called before the first frame update
    void Start()
    {
        meuRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {


      /*  if(Input.GetMouseButtonDown(0) && meuRB.isKinematic == false && trava ==0)
        {
            libera = true;
            trava = 1;
        }*/

        if(Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Ended && trava < 2 && meuRB.isKinematic == false)
            {
                trava++;
                if(trava == 2)
                {
                    libera = true;
                }
                
            }
        }

    }

    void FixedUpdate()
    {
        if(libera)
        {
            meuRB.velocity = meuRB.velocity * 2.5f;
            libera = false;
        }
    }
}
