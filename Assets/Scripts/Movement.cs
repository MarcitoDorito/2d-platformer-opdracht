using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{   public Rigidbody2D rb;
    public float jumpamount = 20;
    public float plMaxspeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.W))
        {
        rb.AddForce(Vector2.up * jumpamount, ForceMode2D.Impulse);
        }
    }

}
