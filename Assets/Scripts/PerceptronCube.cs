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
