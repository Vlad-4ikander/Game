using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour
{
    public void ChangeScene_to_continue(string sceneName) { SceneManager.LoadScene(0); }
    public void ChangeScene_to_redactor(string sceneName) { SceneManager.LoadScene(2); }

    public void ChangeScene_to_menu(string sceneName) { SceneManager.LoadScene(1); }
    public void Exit() { Application.Quit(); }

}
