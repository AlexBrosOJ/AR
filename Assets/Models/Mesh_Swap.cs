using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mesh_Swap : MonoBehaviour
{
    public GameObject objectToReplace; // Объект, у которого нужно заменить mesh
    public Mesh newMesh; // Новый mesh для замены

    private Button button; // Ссылка на компонент кнопки
    private MeshFilter meshFilter; // Ссылка на компонент MeshFilter объекта

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ReplaceMesh);

        meshFilter = objectToReplace.GetComponent<MeshFilter>();
    }

    private void ReplaceMesh()
    {
        // Проверяем, что у объекта и компонента MeshFilter есть ссылки
        if (objectToReplace != null && meshFilter != null)
        {
            // Заменяем mesh у компонента MeshFilter новым mesh
            meshFilter.mesh = newMesh;
        }
        else
        {
            Debug.LogError("Object or MeshFilter component is missing!");
        }
    }
}