using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    public float speed, rpoint, lpoint, uspeed;
    private float lc, rc;
    private Vector3 left, LeftCenter, RightCenter, right;
   
    private Rigidbody2D LeftRigid, RightRigid;
    private GameObject LeftBlocks, RightBlocks;
    // Start is called before the first frame update
    void Start()
    {
        RightBlocks = GameObject.Find("RightBlocks");
        LeftBlocks = GameObject.Find("LeftBlocks");
        lc = LeftBlocks.transform.position.x;
        rc = RightBlocks.transform.position.x;
        
        
       
        LeftBlocks = GameObject.Find("LeftBlocks");
        LeftRigid = LeftBlocks.GetComponent<Rigidbody2D>();
        RightRigid = RightBlocks.GetComponent<Rigidbody2D>();

        print(LeftBlocks.transform.position);
        print(RightBlocks.transform.position);



    }

    // Update is called once per frame
    void Update()
    {
        LeftCenter = new Vector3(lc, LeftBlocks.transform.position.y, 0);
        RightCenter = new Vector3(rc, RightBlocks.transform.position.y, 0);
        right = new Vector3(rpoint, RightBlocks.transform.position.y, 0);
        left = new Vector3(lpoint, LeftBlocks.transform.position.y, 0);
       
        MoveBlock();
    }

    void MoveBlock()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {

            LeftBlocks.transform.position = Vector2.Lerp(LeftBlocks.transform.position, left, speed * Time.deltaTime);
          

        } else 
        {
            
            LeftBlocks.transform.position = Vector2.Lerp(LeftBlocks.transform.position, LeftCenter, 2*speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            RightBlocks.transform.position = Vector2.Lerp(RightBlocks.transform.position, right, speed * Time.deltaTime);

        }
        else
        {
            RightBlocks.transform.position = Vector2.Lerp(RightBlocks.transform.position, RightCenter, 2*speed * Time.deltaTime);
        }


    }
}
