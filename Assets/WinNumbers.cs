using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class WinNumbers : MonoBehaviour {
    public List<string> win_list = new List<string>();
   
    string num = "";
    int n = 3;
    int[] arr1 = new int[] { 0, 1, 2 };
    int[] arr2 = new int[] { 3, 4, 5 };
    int[] arr3 = new int[] { 6, 7, 8 };

    // Use this for initialization
    public static WinNumbers _objwinlist;
    private void Awake()
    {
        _objwinlist = this;
        win_list.Add("0-3-6");
        win_list.Add("1-4-7");
        win_list.Add("2-5-8");
        win_list.Add("0-4-8");
        win_list.Add("2-4-6");
        win_list.Add("6-4-2");
        win_list.Add("8-4-0");

       
    }
    void Start()
    {
        Comobantion(arr1, 0, n - 1);
        call();
    }

    public void Comobantion(int[] list, int k, int m)
    {

        int i;
        if (k == m)
        {
            for (i = 0; i <= m; i++)
            {

                //Console.Write("{0}", list[i]);
                //Console.Write(" ");
                // Debug.LogFormat("{0}", list[i]);
                num += list[i] + "-";
             
            }
            // Debug.Log(num.TrimEnd('-'));
            //  Debug.Log("");
            win_list.Add(num.TrimEnd('-'));
            num = "";
            if (win_list.Count == 12)
            {
                 Comobantion(arr2, 0, n - 1);
            }
            if (win_list.Count == 18)
            {
                 Comobantion(arr3, 0, n - 1);
            }

          
        }
        else
            for (i = k; i <= m; i++)
            {
                swapTwoNumber(ref list[k], ref list[i]);
                Comobantion(list, k + 1, m);
                swapTwoNumber(ref list[k], ref list[i]);
            }



    }

    public void swapTwoNumber(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }



    public void call()
    {
        print(win_list.Count + "c");
        print("--------------");
        foreach (var item in win_list)
        {

            Debug.Log(item);
        }
    }

}