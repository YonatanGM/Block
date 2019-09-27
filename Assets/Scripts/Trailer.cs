using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trailer : MonoBehaviour
{
    private Vector3 originalpos;
    // Start is called before the first frame update
    void Start()
    {
        originalpos = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        int i = Random.Range(-1, 2);
        float x = transform.position.y + i;
        Mathf.Clamp(x, -2, 2);
        int k = Random.Range(0, 5);
        Vector2 nextpos = new Vector2(transform.position.x, x);
        transform.position = Vector2.MoveTowards(transform.position, nextpos, k * Time.deltaTime);
        



    }

}
