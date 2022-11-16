using UnityEngine;

public class Array : MonoBehaviour
{
    public int[] array;
    public int[] array1 = new int[4];
    public int[] array2 = new int[4] { 21, 22, 23, 24 };
    public int[] array3 = new int[7] {31, 32 ,33, 34, 35, 36, 37};
    public string[] array4 = new string[10];
    public GameObject[] arrayColoredImagesRed;
    void Start()
    {
        for (int i = 0; i < array4.Length; i++)
        {
            array4[i] = "array4";
        }

        arrayColoredImagesRed = GameObject.FindGameObjectsWithTag("RedImage");


        //jeweils das erste
        Debug.Log(array1[0]);
        Debug.Log(array2[0]);
        Debug.Log(array3[0]);
        Debug.Log(array4[0]);
        Debug.Log(arrayColoredImagesRed[0]);

        //jeweils das letzte
        Debug.Log(array1[array1.Length - 1]);
        Debug.Log(array2[array2.Length - 1]);
        Debug.Log(array3[array3.Length - 1]);
        Debug.Log(array4[array4.Length - 1]);
        Debug.Log(arrayColoredImagesRed[arrayColoredImagesRed.Length - 1]);


        for (int i = 0; i < array3.Length; i++)
        {
            Debug.Log(array3[i]);
        }

        AlleWerte();

    }

    void AlleWerte()
    {
        Debug.Log(array2[0] + " " + array2[1] + " " + array2[2] + " " + array2[3]);
    }

  
    void Update()
    {
        
    }
}
