using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] private GameObject retryMenu;
    private void Start()
    {
        Cursor.visible = false;

        Time.timeScale = 1f;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Exit();
    }
    public void ShowRetryMenu()
    {
        Cursor.visible = true;

        retryMenu.SetActive(true);

        Time.timeScale = 0f;
    }    
    public void Retry()
    {
        SceneManager.LoadScene("Main");
    }
    private void Exit()
    {
        Application.Quit();
    }
}
