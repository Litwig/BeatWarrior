using UnityEngine;

public class QuadScript : MonoBehaviour
{
    public float scrollSpeed = 0.5f;
    private Renderer rend;
    public bool isGameOver = false;

    private void Start()
    {
        rend = GetComponent<Renderer>();
    }

    private void Update()
    {
        if (isGameOver == false)
        {
            float offset = Time.time * scrollSpeed;
            rend.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
        }
        else
        {
            scrollSpeed -= Time.deltaTime;

            if (scrollSpeed <= 0)
            {
                return;
            }
        }
    }
}