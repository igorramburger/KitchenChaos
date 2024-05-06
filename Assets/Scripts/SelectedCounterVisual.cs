using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedCounterVisual : MonoBehaviour
{

    [SerializeField] private BaseCounter baseCounter;
    [SerializeField] private GameObject[] visualGameObjectArray;


    private void Start()
    {
        Player.Instance.OnSelectedcounterChanged += Player_OnSelectedcounterChanged;
    }

    private void Player_OnSelectedcounterChanged(object sender, Player.OnSelectedCounterChangedEventArgs e)
    {
        if (e.selectedCounter == baseCounter)
        {
            Show();
        }
        else
        {
            Hide();
        }
    }

    private void Show()
    {
        foreach(var visualGameObject in visualGameObjectArray)
        {
            visualGameObject.gameObject.SetActive(true);
        }
    }

    private void Hide()
    {
        foreach (var visualGameObject in visualGameObjectArray)
        {
            visualGameObject.gameObject.SetActive(false);
        }
    }
}
