using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public void PlayGame()
    {
        SceneManager.LoadScene("1P");
    }

    public void PlayGame2P()
    {
        SceneManager.LoadScene("2P");

    }
    public void QuitGame()
    {
        Application.Quit();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
