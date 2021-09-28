using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] private GameObject retryMenu;
    private void Start()
    {
        Time.timeScale = 1f;
    }
    public void ShowRetryMenu()
    {
        retryMenu.SetActive(true);
        Time.timeScale = 0f;
    }    
    public void Retry()
    {
        SceneManager.LoadScene("Main");
    }    
}
