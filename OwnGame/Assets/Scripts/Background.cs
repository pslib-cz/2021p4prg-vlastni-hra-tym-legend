using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Background : MonoBehaviour
{
    public Transform t;
    public float speed = 5;
    public int difficulty = 3;
    public CharacterScript character;
    public Text scoreText;
    public float score = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (!character.isDead)
        {
            t.Translate(-speed * Time.deltaTime, 0, 0);
            Time.timeScale += Time.deltaTime * difficulty * 0.002f;

            if (t.transform.position.x < -18.91f)
            {
                t.transform.position = new Vector3(0, 0, 10f);
            }
            score += Time.deltaTime * 5f;
            scoreText.text = Mathf.Round(score).ToString() + " m";
        }
    }
}
