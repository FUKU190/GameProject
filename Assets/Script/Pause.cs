using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

    public Pause1 Pause0;
    [SerializeField]
    private GameObject Menu;
    [SerializeField]
    private GameObject Camera;
    [SerializeField]
    private GameObject UI;
    [SerializeField]
    private CanvasGroup Panel;

    public void GameReStart()
    {
        //Destroy(Pause0.obj);
        UI.SetActive(false);
        Menu.SetActive(true);
        Camera.SetActive(true);
        Panel.alpha = 0;
        Time.timeScale = 1;
    }
}
