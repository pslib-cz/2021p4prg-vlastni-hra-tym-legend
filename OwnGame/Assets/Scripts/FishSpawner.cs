using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawner : MonoBehaviour
{
    private float secondsLeft = 0;
    public float spawnSpeed = 10;
    public float spawnChance = 40;
    public GameObject obstPrefab;
    public CharacterScript character;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!character.isDead)
        {
            secondsLeft -= Time.deltaTime;
            int temp = Random.Range(0, 100);

            if (temp <= spawnChance && secondsLeft <= 0)
            {
                Instantiate(obstPrefab, new Vector3(20, Random.Range(-4, 4), 0), Quaternion.identity, transform);
                secondsLeft = spawnSpeed;
            }
        }
    }
}
