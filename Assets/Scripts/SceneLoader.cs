using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadARscene()
    {
        SceneManager.LoadScene("AR indicator");
    }
    public void LoadUI2scene()
    {
        SceneManager.LoadScene("SCROLL Ui");
    }



}
