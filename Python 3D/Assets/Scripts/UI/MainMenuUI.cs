using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    public Texture2D cursor;

    void Awake()
    {
        Cursor.SetCursor(cursor, Vector2.zero, CursorMode.Auto);
    }
    public void BtnStart_Click()
    {
       
        SceneManager.LoadScene(1);
    }

    public void BtnExit_Click()
    {
        Application.Quit(0);
    }
}
