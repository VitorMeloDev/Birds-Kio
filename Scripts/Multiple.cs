using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Multiple : MonoBehaviour
{
    private Vector3 start;
    public Rigidbody2D passa1, passa2, passaroRB, PassaPrefab;
    private bool libera;
    public int trava = 0;
    private Touch touch;
    private TrailRenderer rastro;
    // Start is called before the first frame update
    void Start()
    {
        passaroRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && passaroRB.isKinematic == false && trava == 0)
        {
            libera = true;


            start = transform.position;
            passa1 = Instantiate(PassaPrefab, new Vector3(start.x, start.y + 0.1f, start.z), Quaternion.identity);
            passa2 = Instantiate(PassaPrefab, new Vector3(start.x, start.y - 0.1f, start.z), Quaternion.identity);
            trava = 1;
        }
    }

     void FixedUpdate()
    {
        if(libera)
        {
            passa1.velocity = passaroRB.velocity * 1.6f;
            passaroRB.velocity = passaroRB.velocity * 1.4f;
            passa2.velocity = passaroRB.velocity * 1.1f;
            libera = false;
        }
    }
}
