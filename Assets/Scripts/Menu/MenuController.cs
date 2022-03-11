using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuController : MonoBehaviour
{
    public void StartQuiz()
    {
        SceneManager.LoadScene(1);
    }
    public void StartSomething()
    {
        SceneManager.LoadScene(2);
    }
}
