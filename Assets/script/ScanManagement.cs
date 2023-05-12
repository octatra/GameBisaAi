using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ScanManagement : MonoBehaviour
{
    public void Ingame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Exit()
    {
        Application.Quit();
    }
    public void NextLevel2()
    {
        SceneManager.LoadScene("New");
    }
}
