using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaneEffects : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject LeftBox;
        private Transform shadow;
    private LineRenderer lineRenderer;
    private Color Scolor, Ecolor;
    public Animator shake;
    private bool checkr;
    public LeftLaneEffects left;
    void Start()
    {
        GetComponent<ParticleSystem>().Stop();
        shadow = gameObject.transform.GetChild(0);
        shadow.GetComponent<SpriteRenderer>().enabled = false;

        checkr = false;
        LeftBox = GameObject.Find("RightBlocks");
        lineRenderer = GetComponent<LineRenderer>();
        Scolor = lineRenderer.startColor;
        Ecolor = lineRenderer.endColor;
            
    }


    // Update is called once per frame
    void Update()
    {
        if (checkr && left.check) { shake.SetBool("isTouchingB", true); print(true); } 
        else { shake.SetBool("isTouchingB", false); }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Rcollider"))
        {
            GetComponent<ParticleSystem>().Play();
            lineRenderer.startColor = Color.white;
            lineRenderer.endColor = Color.white;
            shadow.GetComponent<SpriteRenderer>().enabled = true;
            shake.SetBool("isTouchingR", true);
            checkr = true;
        }


    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Rcollider"))
        {
            checkr = false;
            lineRenderer.startColor = Scolor;
            lineRenderer.endColor = Ecolor;
            shadow.GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<ParticleSystem>().Stop();
            shake.SetBool("isTouchingR", false);
            shake.SetBool("isTouchingB", false);
            
     
        }
    }

}
