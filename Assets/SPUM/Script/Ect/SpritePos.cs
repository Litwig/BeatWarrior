﻿using UnityEngine;

[ExecuteInEditMode]
public class SpritePos : MonoBehaviour
{
#if UNITY_EDITOR

    // Update is called once per frame
    private void Update()
    {
        float tX = transform.localPosition.x;
        float tY = transform.localPosition.y;
        tX = tX - (tX % 0.015625f);
        tY = tY - (tY % 0.015625f);
        transform.localPosition = new Vector3(tX, tY, 0);
    }

#endif
}