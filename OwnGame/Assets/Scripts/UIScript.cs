using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
    GameObject[] pauseObjects;
    public float PreviousTime = 0;

    public JetpackScript JetpackScript;
    public CollectScript CollectScript;
    public BackgroundSoundScript BackgroundSoundScript;

    void Start()
    {
        pauseObjects = GameObject.FindGameObjectsWithTag("Pause");
        foreach (GameObject g in pauseObjects)
        {
            g.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (PreviousTime == 0)
            {
                BackgroundSoundScript.Pause();
                JetpackScript.Pause();
                CollectScript.Pause();
                PreviousTime = Time.timeScale;
                Time.timeScale = 0;
                foreach (GameObject g in pauseObjects)
                {
                    g.SetActive(true);
                }
            }
            else
            {
                BackgroundSoundScript.UnPause();
                JetpackScript.UnPause();
                CollectScript.UnPause();
                Time.timeScale = 0;
                Time.timeScale += PreviousTime;
                PreviousTime = 0;
                foreach (GameObject g in pauseObjects)
                {
                    g.SetActive(false);
                }
            }
        }
    }

    public void StartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
    }

    public void EndGame()
    {
        Application.Quit();
    }
}
