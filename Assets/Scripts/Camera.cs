using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Vector3 offset;
    public Transform block;
    public float smoothingamount;
  

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 target = block.transform.position + offset;
        transform.position = Vector3.Lerp(transform.position, target, smoothingamount * Time.deltaTime);
    }
}
