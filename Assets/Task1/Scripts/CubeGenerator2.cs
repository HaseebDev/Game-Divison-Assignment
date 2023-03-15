using TMPro;
using UnityEngine;

public class CubeGenerator2 : MonoBehaviour
{
    public GameObject cubePrefab;
    public float spacing = 1.0f;
    public int cubesPerSet = 9;
    public float yOffset = 0.0f;
    public int numCubes = 25;

    private void Start()
    {

        int currentCube = 1;
        int currentSet = 1;

        float middleX = (cubesPerSet / 2) * spacing;

        for (int i = 1; i <= numCubes; i++)
        {
            float currentX = ((currentCube - 1) % cubesPerSet) * spacing;

            if (currentCube == 1)
            {
                GameObject cube = Instantiate(cubePrefab, new Vector3(middleX, yOffset, (currentSet - 1) * spacing * 1.5f), Quaternion.identity);
                cube.transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().text = i.ToString();
            }
            else if (currentCube % 2 == 0)
            {
                GameObject cube = Instantiate(cubePrefab, new Vector3(middleX + currentX, yOffset, (currentSet - 1) * spacing * 1.5f), Quaternion.identity);
                cube.transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().text = i.ToString();
            }
            else
            {
                GameObject cube = Instantiate(cubePrefab, new Vector3(middleX - currentX, yOffset, (currentSet - 1) * spacing * 1.5f), Quaternion.identity);
                cube.transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().text = i.ToString();
            }

            currentCube++;

            if (currentCube > cubesPerSet)
            {
                currentCube = 1;
                currentSet++;
            }
        }
    }
}