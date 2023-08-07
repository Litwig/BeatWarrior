using UnityEngine;
using UnityEngine.UI;
public class CharacterSelect : MonoBehaviour
{
    [SerializeField]
    private Animator animator;

    private Toggle toggle;

    [SerializeField]
    private SelectGrey selectGrey;
    private void Start()
    {
        if(!TryGetComponent(out toggle)) { Debug.Log("Toggle null"); }
    }
    public void SelectCharacter()
    {
        animator.SetBool("isSelect", toggle.isOn);
        selectGrey.isSelect = toggle.isOn;
    }
}
