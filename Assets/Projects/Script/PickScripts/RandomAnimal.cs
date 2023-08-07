using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAnimal : MonoBehaviour
{
    [SerializeField] private Transform contentTransform;

    private void Start()
    {
        this.RandomButton();
    }

    public void RandomButton()
    {
        // Lấy danh sách các phần tử con của Scroll View và lưu chúng vào một danh sách
        List<Transform> children = new List<Transform>();
        foreach (Transform child in contentTransform)
        {
            children.Add(child);
        }

        // Tạo một danh sách mới để lưu trữ thứ tự hoán đổi các phần tử con
        List<int> randomIndices = new List<int>();

        // Lấy một mảng hoán vị của chỉ số từ 0 đến số lượng phần tử con - 1
        int[] indices = new int[children.Count];
        for (int i = 0; i < indices.Length; i++)
        {
            indices[i] = i;
        }
        ShuffleArray(indices);

        // Đặt lại vị trí của từng phần tử con theo thứ tự mới đã hoán vị
        for (int i = 0; i < indices.Length; i++)
        {
            int newIndex = indices[i];
            children[newIndex].SetSiblingIndex(i);
            randomIndices.Add(newIndex);
        }
    }

    // Phương thức hoán vị mảng
    private void ShuffleArray<T>(T[] array)
    {
        int n = array.Length;
        while (n > 1)
        {
            n--;
            int k = Random.Range(0, n + 1);
            T value = array[k];
            array[k] = array[n];
            array[n] = value;
        }
    }
}
