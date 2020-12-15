using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuUI : MonoBehaviour
{
   public void OnClinckOnlineButton()
    {
        Debug.Log("Click Online");
    }

    public void OnClickQuitButton()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;

        Application.Quit();
#endif
    }
}


