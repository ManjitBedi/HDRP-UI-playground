using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

/// <summary>
/// This component is attached to the UI document in the scene.
/// </summary>
public class BackMenu : MonoBehaviour
{
    private void OnEnable()
    {
        ConfigureUI();
    }

    private void ConfigureUI()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        Button backButton = root.Q<Button>("BackButton");
        backButton.clicked += () => SceneManager.LoadScene("Simple Menu");
    }
}
