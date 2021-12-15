using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsScript : MonoBehaviour
{
    private float x;
    public float Speed = -1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x = transform.position.x;
        x += Speed * Time.deltaTime;
        transform.position = new Vector3(x, transform.position.y, transform.position.z);
    }
}
