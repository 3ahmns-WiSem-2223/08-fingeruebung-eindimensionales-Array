using UnityEngine;

public class Array : MonoBehaviour
{
    [SerializeField]
    int[] array;
    [SerializeField]
    int[] array1 = new int[4];
    [SerializeField]
    int[] array2 = new int[4] { 21, 22, 23, 24 };
    [SerializeField]
    int[] array3 = new int[7] {31, 32 ,33, 34, 35, 36, 37};
    [SerializeField]
    string[] array4 = new string[10];
    [SerializeField]
    GameObject[] arrayColoredImagesRed;
    [SerializeField]
    int[] arra5 = new int[25];
    [SerializeField]
    int[] array6 = new int[250];
    [SerializeField]
    int[] array7 = new int[250];
    [SerializeField]
    string[] array8 = new string[100];
    [SerializeField]
    int[] array9 = new int[1000];
    [SerializeField]
    int[] array10 = new int[275];
    [SerializeField]
    int[] array11 = new int[1000];

    int a = 20;
    int b = 0;
    int c = -1;

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

        array1[3] = 3;
        Debug.Log(array1[3]);

        array2[2] = 203;
        Debug.Log(array2[2]);

        array3[3] = 333;
        Debug.Log(array3[3]);

        array4[2] = "heute";
        Debug.Log(array4[2]);

        arrayColoredImagesRed[2].GetComponent<SpriteRenderer>().color = Color.green;

        for (int i = 0; i < arra5.Length; i ++)
        {
            a += 2;
            arra5[i] = a;
        }

        for (int i = 0; i < array6.Length; i++)
        {
            b += 2;
            array6[i] = b;
        }

        for (int i = 0; i < array7.Length; i++)
        {
            
            c += 2;
            array7[i] = c;
        }

        for (int i = 1; i < array8.Length; i += 2)
        {
            array8[i] = "b";
        }

        for (int i = 0; i < array8.Length; i += 2)
        {
            array8[i] = "a";
        }

        for (int i = 0; i < array9.Length; i++)
        {
            array9[i] = UnityEngine.Random.Range(0, 10);
            Debug.Log(array9[i]);
        }

        System.Array.Sort(array9);
        for (int i = 0; i < array9.Length; i++)
        {
            
            Debug.Log(array9[i]);
        }

        for (int i = 0; i < array11.Length; i++)
        {
            array11[i] = UnityEngine.Random.Range(0, 10);
        }
        System.Array.Sort(array11);
        for (int i = 0; i < array9.Length; i++)
        {
            
            Debug.Log(array9[i]);
        }

    }

    void AlleWerte()
    {
        Debug.Log(array2[0] + " " + array2[1] + " " + array2[2] + " " + array2[3]);
    }

  
    void Update()
    {
        
    }
}
