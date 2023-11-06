# АНАЛИЗ ДАННЫХ И ИСКУССТВЕННЫЙ ИНТЕЛЛЕКТ [in GameDev]
Отчет по лабораторной работе #4 выполнил:
- Устинов Эрик Константинович
- ФО-220007

Отметка о выполнении заданий (заполняется студентом):

| Задание | Выполнение | Баллы |
| ------ | ------ | ------ |
| Задание 1 | * | 60 |
| Задание 2 | * | 20 |
| Задание 3 | * | 20 |

знак "*" - задание выполнено; знак "#" - задание не выполнено;

Работу проверили:
- к.т.н., доцент Денисов Д.В.
- к.э.н., доцент Панов М.А.
- ст. преп., Фадеев В.О.

[![N|Solid](https://cldup.com/dTxpPi9lDf.thumb.png)](https://nodesource.com/products/nsolid)

[![Build Status](https://travis-ci.org/joemccann/dillinger.svg?branch=master)](https://travis-ci.org/joemccann/dillinger)

Структура отчета

- Данные о работе: название работы, фио, группа, выполненные задания.
- Цель работы.
- Задание 1.
- Код реализации выполнения задания. Визуализация результатов выполнения (если применимо).
- Задание 2.
- Код реализации выполнения задания. Визуализация результатов выполнения (если применимо).
- Задание 3.
- Код реализации выполнения задания. Визуализация результатов выполнения (если применимо).
- Выводы.
- ✨Magic ✨

## Цель работы

Изучить работу перцептрона.

## Задание 1
### В проекте Unity реализовать перцептрон, который умеет производить вычисления: OR, AND, NAND, XOR.

- OR. Работает корректно, обучается за 4 эпохи.
- AND. Работает корректно, обучается за 7 эпох.
- NAND. Работает корректно, обучается за 4 эпох.
- XOR. Работает некорректно, т.к. XOR - нелинейная функция.

## Задание 2
### Построить графики зависимости количества эпох от ошибки  обучения. Указать от чего зависит необходимое количество эпох обучения.

![image](https://github.com/Usterik/Workshop4/assets/149312199/030acc97-578b-461c-8bd5-7d21e108bcca)

- https://docs.google.com/spreadsheets/d/19AQmcfziBaUBxJkty2qxx67gvf8kvd3tm6eFHlwMaL8/edit#gid=0
- Необходимое количество эпох зависит от сложности задачи.

## Задание 3
### Построить визуальную модель работы перцептрона на сцене Unity.

![image](https://github.com/Usterik/Workshop4/assets/149312199/1b2edd4f-8c13-46b1-acc5-c673f8a23c50)

- Для построения визуальной модели я использовал кубы, компонент Rigidbody, методы OnTriggerEnter и OnCollisionEnter.

```cs

using UnityEngine;

public class PerceptronCube : MonoBehaviour
{
    public Material zeroMaterial;
    public Material oneMaterial;

    private Perceptron perceptron;

    private void Start()
    {
        perceptron = GetComponent<Perceptron>();
        if (perceptron.CalcOutput(0, 0) == 0)
            GetComponent<MeshRenderer>().material = zeroMaterial;
        else
            GetComponent<MeshRenderer>().material = oneMaterial;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (perceptron.CalcOutput(0, 1) == 0)
            GetComponent<MeshRenderer>().material = zeroMaterial;
        else
            GetComponent<MeshRenderer>().material = oneMaterial;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (perceptron.CalcOutput(1, 1) == 0)
            GetComponent<MeshRenderer>().material = zeroMaterial;
        else
            GetComponent<MeshRenderer>().material = oneMaterial;
    }
}

```

## Выводы
Я разобрался в работе перцептрона и реализовал их в Unity.

| Plugin | README |
| ------ | ------ |
| Dropbox | [plugins/dropbox/README.md][PlDb] |
| GitHub | [plugins/github/README.md][PlGh] |
| Google Drive | [plugins/googledrive/README.md][PlGd] |
| OneDrive | [plugins/onedrive/README.md][PlOd] |
| Medium | [plugins/medium/README.md][PlMe] |
| Google Analytics | [plugins/googleanalytics/README.md][PlGa] |

## Powered by

**BigDigital Team: Denisov | Fadeev | Panov**
