using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChase : MonoBehaviour
{
    [SerializeField] GameObject chaseObject;
    Vector3 difVector;
    //エディターでカメラの高さを指定
    public float difPosY;

    // Start is called before the first frame update
    void Start()
    {
        difVector = chaseObject.transform.position - this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = chaseObject.transform.position - difVector;
        this.transform.position = new Vector3(this.transform.position.x, difPosY, this.transform.position.z);
    }
}
