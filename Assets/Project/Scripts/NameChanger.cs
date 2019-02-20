using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class NameChanger : MonoBehaviour
{
    [SerializeField]
    private InputField _inputField = null;

    [SerializeField]
    private Text _display = null;

    void Start()
    {
        _inputField.onValueChanged.AddListener(ShowDisplayName);
    }

    private void ShowDisplayName(string newName)
    {
        _display.text = newName.Length > 0 ? $"なまえ：{newName}" : "名無し";
    }
}
