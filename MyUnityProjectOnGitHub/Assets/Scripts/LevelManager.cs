using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public Button scene1;
    public Button scene2;
    public Button scene3;
    public Button backButton;
    public string scene_1;
    public string scene_2;
    public string scene_3;
    public string mainMenu;

    // Start is called before the first frame update
    void Start()
    {
        if (scene1 != null ) scene1.onClick.AddListener(Onscene1ButtonClick);
        if (scene2 != null) scene2.onClick.AddListener(Onscene2ButtonClick);
        if (scene3 != null) scene3.onClick.AddListener(Onscene3ButtonClick);
        if (backButton != null)
        {
            backButton.onClick.AddListener(OnbackButtonClick);
        }
    }

    private void Onscene1ButtonClick()
    {
        SceneManager.LoadScene(scene_1);
    }

    private void Onscene2ButtonClick()
    {
        SceneManager.LoadScene(scene_2);
    }

    private void Onscene3ButtonClick()
    {
        SceneManager.LoadScene(scene_3);
    }

    private void OnbackButtonClick()
    {
        SceneManager.LoadScene(mainMenu);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
