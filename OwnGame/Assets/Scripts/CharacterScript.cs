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
    public int fishes = 0;
    public Text fishesText;
    private Animator _anim;
    public bool onGround = false;

    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isDead)
        {
            onGround = coll.IsTouchingLayers();
            if (Input.GetKey(KeyCode.Space))
            {
                _anim.SetBool("JetpackOn", true);
                rb.AddForce(new Vector2(0, upSpeed * (Time.timeScale)), ForceMode2D.Force);
            }
            else
            {
                _anim.SetBool("JetpackOn", false);
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
