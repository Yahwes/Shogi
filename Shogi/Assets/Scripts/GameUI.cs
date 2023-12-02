using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameUI : MonoBehaviour
{

    public void OnLocalGameButton()
    {
        SceneManager.LoadScene(1);
    }
}
