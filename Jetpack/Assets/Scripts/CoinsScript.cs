using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsScript : MonoBehaviour
{
    private float c;
    public float Speed = -1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        c = transform.position.x;
        c += Speed * Time.deltaTime;
        transform.position = new Vector3(c, transform.position.y, transform.position.z);
    }
}
