using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour

{
    public string Newgame;
    public void Newgamedanspanel()
    {
        SceneManager.LoadScene(Newgame);
    }
    public void Exitgame()
    {
        Application.Quit();
    }
}
