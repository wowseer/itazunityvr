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
        if (settingsPanel.active)
        {
            Debug.Log("Einstellungsfenster wird geschlossen");
            settingsPanel.SetActive(false);
        }
        else
        {
            Debug.Log("Einstellungsfenster wird geöffnet");
            settingsPanel.SetActive(true);
        }
    }
}