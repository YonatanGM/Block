using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullBlock : MonoBehaviour
{
    public float speed, amount;
    private Rigidbody2D BlockRigid;
    private Vector3 i;
    // Start is called before the first frame update
    void Start()
    {
        i = new Vector3(0, -amount, 0);
        BlockRigid = GetComponent<Rigidbody2D>();
        

    }

    // Update is called once per frame
    void Update()
    {
        //  transform.position = transform.position + i;
        AddVelocity();
        // i += new Vector3(0, speed, 0);
        //transform.position = transform.position + i;
        //Vector2.MoveTowards(transform.position, transform.position + i, speed * Time.deltaTime);
    }


    void AddVelocity ()
    {
        BlockRigid.velocity = i;
    }
}
