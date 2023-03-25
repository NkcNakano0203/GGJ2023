using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClearTxtMover : MonoBehaviour
{
    TMP_Text textComponent;
    TMP_TextInfo textInfo;

    [SerializeField]
    float offset = 0.5f;

    void Start()
    {
        textComponent = GetComponent<TMP_Text>();
    }

    void Update()
    {
        SinWave();
    }

    private void SinWave()
    {
        textComponent.ForceMeshUpdate();
        textInfo = textComponent.textInfo;

        var count = Mathf.Min(textInfo.characterCount, textInfo.characterInfo.Length);
        for (int i = 0; i < count; i++)
        {
            var charInfo = textInfo.characterInfo[i];
            if (!charInfo.isVisible)
                continue;

            int materialIndex = charInfo.materialReferenceIndex;
            int vertexIndex = charInfo.vertexIndex;

            // Wave
            Vector3[] verts = textInfo.meshInfo[materialIndex].vertices;

            float sinWaveOffset = offset * i;
            float sinWave = Mathf.Sin(sinWaveOffset + Time.realtimeSinceStartup * Mathf.PI);
            verts[vertexIndex + 0].y += sinWave;
            verts[vertexIndex + 1].y += sinWave;
            verts[vertexIndex + 2].y += sinWave;
            verts[vertexIndex + 3].y += sinWave;
        }
        for (int i = 0; i < textInfo.materialCount; i++)
        {
            if (this.textInfo.meshInfo[i].mesh == null) { continue; }

            textInfo.meshInfo[i].mesh.vertices = textInfo.meshInfo[i].vertices;  // •ÏX
            textComponent.UpdateGeometry(textInfo.meshInfo[i].mesh, i);
        }
    }
}