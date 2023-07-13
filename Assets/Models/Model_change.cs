using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Model_change : MonoBehaviour
{
    public GameObject modelToReplace; // Модель, которую нужно заменить
    public GameObject newModel; // Новая модель для замены

    private Button button; // Ссылка на компонент кнопки

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ReplaceModel);
    }

    private void ReplaceModel()
    {
        // Создаем новую модель на позиции и с ориентацией старой модели
        GameObject instantiatedModel = Instantiate(newModel, modelToReplace.transform.position, modelToReplace.transform.rotation);

        // Копируем родительский объект старой модели к новой модели
        instantiatedModel.transform.SetParent(modelToReplace.transform.parent);

        // Удаляем старую модель
        Destroy(modelToReplace);

        // Присваиваем ссылку на новую модель
        modelToReplace = instantiatedModel;
    }
}