using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

/// <summary>
/// This component is attached to the UI document in the scene.
/// </summary>
public class MainMenu : MonoBehaviour
{
    private void OnEnable()
    {
        ConfigureUI();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ConfigureUI()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        //  Get references to the buttons in the menu document.
        Button infoButton = root.Q<Button>("ButtonDisplayInfo");
        Button loadScene1Button = root.Q<Button>("ButtonLoadScene1");
        Button loadScene2Button = root.Q<Button>("ButtonLoadScene2");

        infoButton.clicked += () => DisplayInfo();
        loadScene1Button.clicked += () => SceneManager.LoadScene("OutdoorsScene");
        loadScene2Button.clicked += () => SceneManager.LoadScene("IndoorsScene");
    }

    private void DisplayInfo()
    {
        Debug.Log("button clicked");
    }
}
