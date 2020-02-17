using UnityEngine;
using UnityEngine.UI;

public class StartMenuPage : MonoBehaviour
{
    public Button PlayButton;
    public LevelSelectPage LevelSelectPage;

    private void Awake()
    {
        PlayButton.onClick.AddListener(OpenLevelSelect);
    }

    private void OpenLevelSelect()
    {
        LevelSelectPage.ShowLevelSelect();
    }
}
