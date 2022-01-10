using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScript : MonoBehaviour
{
    public Transform t;
    public float speed = 0.03f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t.Translate(-speed * 0.1f, 0, 0);

        if (t.transform.position.x < -13f)
        {
            t.transform.position = new Vector3(0, 0, 10f);
        }
    }
}