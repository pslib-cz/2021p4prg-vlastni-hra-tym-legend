using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
    public JetpackScript JetpackScript;
    public CollectScript CollectScript;

    public ParticleSystem particleSystem;

    private ParticleSystem.EmissionModule emission;

    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator>();
        emission = particleSystem.emission;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isDead)
        {
            onGround = coll.IsTouchingLayers();
            if (Input.GetKey(KeyCode.Space))
            {
                if (GameObject.FindGameObjectsWithTag("Pause").Length == 0)
                {
                    JetpackScript.PlaySound();
                }
                rb.AddForce(new Vector2(0, upSpeed * (Time.timeScale)), ForceMode2D.Force);
                emission.enabled = true;
            }
            else
            {
                emission.enabled = false;
                JetpackScript.StopSound();
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Trap"))
        {
            isDead = true;
            SceneManager.LoadScene("DeadScene");
        }
        if (collider.gameObject.CompareTag("Fish"))
        {
            CollectScript.PlaySound();
            fishes++;
            fishesText.text = fishes.ToString();
            Destroy(collider.gameObject);
        }
    }
}
