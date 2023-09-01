using UnityEngine;

public class HowToPlay : MonoBehaviour
{
    [SerializeField]
    private GameObject FirstPanel;

    [SerializeField]
    private GameObject SecondPanel;

    [SerializeField]
    private GameObject HowToPlayPanel;

    [SerializeField]
    private GameObject TitlePanel;

    private void Start()
    {
    }

    public void FirstPanelOn()
    {
        FirstPanel.SetActive(true);
        SecondPanel.SetActive(false);
    }

    public void SecondPanelOn()
    {
        SecondPanel.SetActive(true);
        FirstPanel.SetActive(false);
    }

    public void PanelClose()
    {
        HowToPlayPanel.SetActive(false);
        TitlePanel.SetActive(true);
    }

    public void PanelOpen()
    {
        TitlePanel.SetActive(false);
        HowToPlayPanel.SetActive(true);
        FirstPanel.SetActive(true);
        SecondPanel.SetActive(false);
    }
}