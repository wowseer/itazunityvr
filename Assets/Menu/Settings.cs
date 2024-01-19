using UnityEngine;
using UnityEngine.UI;

public class SettingsButton : MonoBehaviour
{
    public Button settingsButton;
    public GameObject settingsPanel;

    void Start()
    {
        Button btn = settingsButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        settingsPanel.SetActive(false); 
    }

    void TaskOnClick()
    {
        Debug.Log("Einstellungsfenster wird geöffnet");
        settingsPanel.SetActive(true); 
    }
}