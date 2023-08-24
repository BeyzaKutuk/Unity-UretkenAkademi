using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject panel;

    public void StartOnClick()
    {
        panel.gameObject.SetActive(true);
    }

    public void NextOnClick()
    {
        SceneManager.LoadScene(1);
    }

    public void FinishButtonOnClick()
    {
        SceneManager.LoadScene(0);
    }

    public void ExitOnClick()
    {
        Application.Quit();
    }

}
