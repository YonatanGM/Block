using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterElongate : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject block;
    public float extension;
    void Start()
    {
        block = GameObject.Find("Block");
    }

    // Update is called once per frame
    void Update()
    {
        TriggerExtension();
    }

    void TriggerExtension()
    {
      if(transform.position.y - block.transform.position.y < extension)
        {
            GetComponent<Animator>().SetBool("CenterElongate", true);
        } 
       
    }
}
