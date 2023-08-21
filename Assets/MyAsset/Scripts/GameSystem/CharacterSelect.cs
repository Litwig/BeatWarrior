using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class CharacterSelect : MonoBehaviour
{
    [SerializeField]
    private Animator animator;

    private Toggle toggle;

    [SerializeField]
    private SelectGrey selectGrey;

    public bool AnimBool;

    private void Start() 
    {
        if(!TryGetComponent(out toggle)) { Debug.Log("Toggle null"); }
    }

    private void Update()
    {
        AnimBool = toggle.isOn;
    }

    public void SelectCharacter()
    {
        animator.SetBool("isSelect", toggle.isOn);
        selectGrey.isSelect = toggle.isOn;
    }
}