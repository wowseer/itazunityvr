using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BeendenButton : MonoBehaviour
{
    public Button beendenButton;

    void Start()
    {
        Button btn = beendenButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Debug.Log("Spiel wird beendet!");
        Application.Quit();
        
        //Für Editor
        UnityEditor.EditorApplication.isPlaying = false;
    }
}