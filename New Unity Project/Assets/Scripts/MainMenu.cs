using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    private int level, max;

    private TextMeshProUGUI leveldisplay;

    // Start is called before the first frame update
    void Start()
    {
        leveldisplay = GameObject.Find("LevelDisplay").GetComponent<TextMeshProUGUI>();
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            level = 1;
        }
        else Reset();
        
        max = SceneManager.sceneCountInBuildSettings - 1;
        Debug.Log(level);
        Debug.Log(max);
    }

    public void DifficultyUp()
    {
        if (level < max)
        {
            Debug.Log("up");
            level++;
            leveldisplay.text = level.ToString();
        }
    }

    public void DifficultyDown()
    {
        if (level > 1)
        {
            Debug.Log("down");
            level--;
            leveldisplay.text = level.ToString();
        }
    }

    public void StartSimulation()
    {
        SceneManager.LoadScene(level);
    }

    public void QuitApp()
    {
        Application.Quit();
    }

    public void Reset()
    {
        level = SceneManager.GetActiveScene().buildIndex;
        leveldisplay.text = level.ToString();
    }
}