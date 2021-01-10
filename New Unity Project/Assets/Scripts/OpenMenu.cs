using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OpenMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject menu;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            Cursor.lockState = CursorLockMode.Confined;
            gameObject.SetActive(false);
            menu.SetActive(true);
            menu.GetComponent<MainMenu>().Reset();
        }
    }
    public void BackToGame() {
        Cursor.lockState = CursorLockMode.Locked;
    }
}
