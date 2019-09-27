using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftLaneEffects : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject LeftBox;
    private Transform shadow;
    private LineRenderer lineRenderer;
    private Color Scolor, Ecolor;
    public Animator shake;
    public bool check;
    void Start()
    {
        GetComponent<ParticleSystem>().Stop();
        shadow = gameObject.transform.GetChild(0);
        shadow.GetComponent<SpriteRenderer>().enabled = false;
        print(shadow);

        check = false;
        LeftBox = GameObject.Find("LeftBlocks");
        print(LeftBox); ;
        lineRenderer = GetComponent<LineRenderer>();
        Scolor = lineRenderer.startColor;
        Ecolor = lineRenderer.endColor;
        print(Ecolor);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D otherl)
    {

            check = true;

            GetComponent<ParticleSystem>().Play();
            lineRenderer.startColor = Color.white;
            lineRenderer.endColor = Color.white;
            shadow.GetComponent<SpriteRenderer>().enabled = true;
            shake.SetBool("isTouching", true);
       // print(shadow);



    }
    private void OnTriggerExit2D(Collider2D otherl)
    {
        if (otherl.CompareTag("Lcollider"))
        {
            check = false;
            lineRenderer.startColor = Scolor;
            lineRenderer.endColor = Ecolor;
            shadow.GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<ParticleSystem>().Stop();
            shake.SetBool("isTouching", false);
            


        }
    }

}
