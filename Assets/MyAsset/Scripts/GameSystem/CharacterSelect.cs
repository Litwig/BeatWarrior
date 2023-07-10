using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelect : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject[] SelectCharacter;

    private BoxCollider2D[] boxCollider2D;
    //private Animator[] animator;

    private bool isClick;
    void Start()
    {
        boxCollider2D = new BoxCollider2D[SelectCharacter.Length];
       // animator = new Animator[SelectCharacter.Length];
        boxCollider2D[boxCollider2D.Length - 1] 
            = SelectCharacter[SelectCharacter.Length - 1].GetComponent<BoxCollider2D>();

        for(int i = 0; i < boxCollider2D.Length; i++)
        {
            if (boxCollider2D[i] == null)
            {
                Debug.Log("null: " + i);
            }

        }
    }

    void Update()
    {
        SelectAnim();
    }

    private void SelectAnim()
    {
        if(Input.GetMouseButtonDown(0))
        {

            
             for (int i = 0; i < SelectCharacter.Length; i++)
             {
                // animator[i].SetBool("isSelect", true);
             }

            
        }
    }
}
