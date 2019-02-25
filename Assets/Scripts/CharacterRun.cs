using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRun : MonoBehaviour
{
    Rigidbody rb;
    public float runSpeed;
    Vector3 speedVector;

    // Start is called before the first frame update
    void Start()
    {
        speedVector = new Vector3(0, 0, runSpeed);
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = speedVector;
    }
}
