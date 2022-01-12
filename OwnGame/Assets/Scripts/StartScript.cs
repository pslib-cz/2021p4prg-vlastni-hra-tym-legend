using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{
    public Transform t;
    public float speed = 0.03f;
    public DeadScript DeadScript;

    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "DeadScene")
        {
            DeadScript.PlaySound();
        }
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
