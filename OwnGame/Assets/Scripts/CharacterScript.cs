using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float upSpeed = 5;
    public Background Background;
    public TrapSpawner TrapSpawner;
    public bool isDead = false;
    public Collider2D coll;
    public bool onGround = false;
    public int fishes = 0;
    public Text fishesText;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        onGround = coll.IsTouchingLayers();
        if (!isDead)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                rb.AddForce(new Vector2(0, upSpeed * (Time.timeScale)), ForceMode2D.Force);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Trap"))
        {
            isDead = true;
        }
        if (collider.gameObject.CompareTag("Fish"))
        {
            fishes++;
            fishesText.text = fishes.ToString();
            Destroy(collider.gameObject);
        }
    }
}
