using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymovementscript : MonoBehaviour
{
    public float time;
    public Vector3 originalpos;
    public Vector3 left;
    public Vector3 right;
    public Vector3 min;
    public Vector3 max;
    public int isFacing;
    

    // Start is called before the first frame update
    void Start()
    {
        originalpos = GetComponent<Transform>().position;
        isFacing = -1;
    }
    
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(isFacing == -1){
            GetComponent<Rigidbody2D>().AddForce(left);
        }
        if(isFacing == 1){
            GetComponent<Rigidbody2D>().AddForce(right);
        }

    }
    void OnCollisionEnter2D(Collision2D collision){
            if(collision.gameObject.tag == "bullet"){
                Destroy(gameObject);
            }
     }
}
