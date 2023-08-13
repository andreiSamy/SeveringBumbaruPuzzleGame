using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Openl() {
        SceneManager.LoadScene("Level1");
    }
    public void Openlv()
    {
        SceneManager.LoadScene("Level2");
    }
    public void Openlvl()
    {
        SceneManager.LoadScene("Level3");
    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
