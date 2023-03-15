using TMPro;
using UnityEngine;

public class CubeGenerator : MonoBehaviour
{
    public GameObject cubePrefab;
    public int numberOfCubes = 25;
    public float cubeSpacing = 2f;

    void Start()
    {
        int setCount = Mathf.CeilToInt((float)numberOfCubes / 9f);
        int cubesInLastSet = numberOfCubes % 9 == 0 ? 9 : numberOfCubes % 9;

        for (int i = 0; i < setCount; i++)
        {
            int cubesInSet = i == setCount - 1 ? cubesInLastSet : 9;
            int middleIndex = Mathf.CeilToInt((float)cubesInSet / 2f) - 1;

            for (int j = 0; j < cubesInSet; j++)
            {
                int offset = j - middleIndex;
                float xPos = offset * cubeSpacing + (i * 9f * cubeSpacing);

                GameObject cube = Instantiate(cubePrefab, new Vector3(xPos, 0f, i * cubeSpacing), Quaternion.identity);
                cube.GetComponentInChildren<TextMeshPro>().text = (i * 9 + j + 1).ToString();

                if (offset % 2 == 0)
                {
                    cube.transform.Translate(0f, 0f, cubeSpacing * 0.5f * Mathf.Sign(offset));
                }
            }
        }
    }
}