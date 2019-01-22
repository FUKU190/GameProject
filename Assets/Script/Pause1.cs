using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause1 : MonoBehaviour
{
    [SerializeField]
    private CanvasGroup PausePanel;
    [SerializeField]
    private GameObject ui;
    [SerializeField]
    private GameObject MenuButton;
    [SerializeField]
    private GameObject CameraButton;
    public Text FloorText;
    public MoveBlock Floor;

    public void StopGame()
    {
        //obj = Instantiate(ui);
        ui.SetActive(true);
        Time.timeScale = 0;
        PausePanel.alpha = 1;
        CameraButton.SetActive(false);
        MenuButton.SetActive(false);
        FloorText.text = "現在のフロア " + "\n" +  Floor.FloorCount + "階";
    }
}
