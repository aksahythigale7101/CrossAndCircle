using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
public class MainScript : MonoBehaviour
{

    public Toggle[] Toggles;
    public Sprite[] img_player;
    public int count = 0;
    public bool Player1;
    public bool Player2;


    public List<int> player1_list = new List<int>();
    public List<int> player2_list = new List<int>();


    public Text _winText;
    // Use this for initialization
    void Start()
    {


    }



    public void Toggles_Buttons(Toggle name)
    {
        if (count == 0)
        {
            // player1_list.Clear();
            Player1 = true;
            Player2 = false;
            count++;
            name.transform.GetChild(0).GetComponent<Image>().sprite = img_player[0];
            name.transform.GetComponent<Toggle>().interactable = false;
            player1_list.Add(int.Parse(name.name));
            if (player1_list.Count == 3)//&& player1_list.Count ==4)
            {
                FillNumber_count3(player1_list);
            }
            else if (player1_list.Count == 4)
            {
                FillNumber_count4(player1_list);
            }
            else if (player1_list.Count == 5)
            {

            }
        }
        else
        {
            // player2_list.Clear();
            Player1 = false;
            Player2 = true;
            count = 0;
            name.transform.GetChild(0).GetComponent<Image>().sprite = img_player[1];
            name.transform.GetComponent<Toggle>().interactable = false;
            player2_list.Add(int.Parse(name.name));
            if (player2_list.Count == 3)
            {
                FillNumber_count3(player2_list);
            }
            else if (player2_list.Count == 4)
            {
                // FillNumber_count4(player2_list);
            }
        }
    }


    public struct player11
    {
        //public int a;
        //public int b;
        //public int c;
        public string abc;
    }
    public List<player11> structure_list = new List<player11>();
    //-----------------------------------------------------------------------
    public struct player22
    {
        //public int a;
        //public int b;
        //public int c;
        public string abc;
    }
    public List<player22> structure_lis2 = new List<player22>();


    public void FillNumber_count3(List<int> list_players)
    {
        if (Player1)
        {
            player11 num_struct;
            //num_struct.a = list_players[0];  num_struct.b = list_players[1]; num_struct.c = list_players[2];
            num_struct.abc = list_players[0] + "-" + list_players[1] + "-" + list_players[2];
            structure_list.Add(num_struct);


        }
        else
        {
            player22 num_struct1;

            //num_struct.a = list_players[0];  num_struct.b = list_players[1]; num_struct.c = list_players[2];
            num_struct1.abc = list_players[0] + "-" + list_players[1] + "-" + list_players[2];
            structure_lis2.Add(num_struct1);

        }

        Wining_numbers();

    }



    public void FillNumber_count4(List<int> list_players)
    {

        player11 num_struct1;
        num_struct1.abc = list_players[0] + "-" + list_players[1] + "-" + list_players[2];
        structure_list.Add(num_struct1);

        player11 num_struct2;
        num_struct2.abc = list_players[1] + "-" + list_players[2] + "-" + list_players[3];
        structure_list.Add(num_struct2);

        //player11 num_struct3;
        //num_struct3.abc = list_players[0] + "-" + list_players[1] + "-" + list_players[2];
        //structure_list.Add(num_struct3);

        player11 num_struct4;
        num_struct4.abc = list_players[0] + "-" + list_players[1] + "-" + list_players[3];
        structure_list.Add(num_struct4);

        //player11 num_struct5;
        //num_struct5.abc = list_players[0] + "-" + list_players[1] + "-" + list_players[4];
        //structure_list.Add(num_struct5);

        //  player11 num_struct6;
        //num_struct6.abc = list_players[1] + "-" + list_players[0] + "-" + list_players[2];
        //structure_list.Add(num_struct6);


        //player11 num_struct7;
        //num_struct7.abc = list_players[1] + "-" + list_players[0] + "-" + list_players[3];
        //structure_list.Add(num_struct7);

        //player11 num_struct8;
        //num_struct8.abc = list_players[1] + "-" + list_players[0] + "-" + list_players[4];
        //structure_list.Add(num_struct8);

        //player11 num_struct9;
        //num_struct9.abc = list_players[2] + "-" + list_players[0] + "-" + list_players[1];
        //structure_list.Add(num_struct5);

        //player11 num_struct10;
        //num_struct10.abc = list_players[2] + "-" + list_players[0] + "-" + list_players[3];
        //structure_list.Add(num_struct10);

        //player11 num_struct11;
        //num_struct11.abc = list_players[2] + "-" + list_players[0] + "-" + list_players[4];
        //structure_list.Add(num_struct11);

        //player11 num_struct13;
        //num_struct13.abc = list_players[3] + "-" + list_players[0] + "-" + list_players[4];
        //structure_list.Add(num_struct5);




        Wining_numbers();
    }









    public void Wining_numbers()
    {



        //bool isEqual = Enumerable.SequenceEqual(structure_list.ToString(), win_list.ToString());
        //if (isEqual)
        //{
        //    Debug.Log("Player is win");
        //}



        if (Player1)
        {
            print("player1");

            foreach (var w1 in structure_list)
            {
                foreach (var w2 in WinNumbers._objwinlist.win_list)
                {
                    if (w2.Contains(w1.abc.ToString()))
                    {
                        if (Player1)
                        {
                            Debug.Log("Player Win1111111111");
                            _winText.text = "Player 1 Is Win !!!";
                            break;
                        }

                    }
                }
            }
        }
        else
        {
            print("player2");
            //foreach (var w1 in structure_lis2)
            //{
            //    foreach (var w2 in WinNumbers._objwinlist.win_list)
            //    {
            //        if (w2.Contains(w1.abc.ToString()))
            //        {
            //            if (Player2)
            //            {
            //                Debug.Log("Player Win222222");
            //                break;
            //            }

            //        }
            //    }
            //}
            foreach (var w1 in structure_lis2)
            {
                var w1Numbers = w1.abc.ToString().Split('-').OrderBy(n => n).ToList();

                foreach (var w2 in WinNumbers._objwinlist.win_list)
                {
                    var w2Numbers = w2.Split('-').OrderBy(n => n).ToList();

                    if (w1Numbers.SequenceEqual(w2Numbers))
                    {
                        if (Player2)
                        {
                            Debug.Log("Player Win222222");
                            _winText.text = "Player 2 Is Win !!!";
                            break;
                        }
                    }
                }
            }



            // Debug.Log(WinNumbers._objwinlist.win_list.Count);







        }
    }
}
