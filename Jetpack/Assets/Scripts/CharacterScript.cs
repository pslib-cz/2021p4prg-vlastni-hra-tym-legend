using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{
    public float jumpSpeed = 5;
    public int crystals = 0;

    private Rigidbody2D _rb;
    private Collider2D _coll;
    private Animator _anim;
    private bool _onGround = false;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _coll = GetComponent<Collider2D>();
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //x = transform.position.x;
        //x += speed * Time.deltaTime;
        //transform.position = new Vector3(x, transform.position.y, transform.position.z);
        _onGround = _coll.IsTouchingLayers();
        if (Input.GetMouseButton(0))
        {
            _anim.SetBool("isFlying", true);
            _rb.AddForce(new Vector2(0, jumpSpeed), ForceMode2D.Force);
        }
        else
        {
            _anim.SetBool("isFlying", false);
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Crystal"))
        {
            Collect(collider);
        }
    }

    void Collect(Collider2D Collider)
    {
        crystals++;
        Destroy(Collider.gameObject);
    }
}
