﻿using System.Collections.Generic;
using UnityEngine;

public class Structure{

    public Dictionary<int,int[,]> listStruct = new Dictionary<int, int[,]>();

	// Use this for initialization
	public Structure() {

        int[,] tab = { { 1, 1, 1, 1} , 
                       { 1, 0, 0, 1} ,
                       { 1, 0, 0, 1} ,
                       { 1, 1, 1, 1} };
        listStruct.Add(1, tab);

        int[,] tab2 = { { 1, 1, 1, 0} ,
                        { 1, 0, 1, 1} ,
                        { 1, 1, 1, 1} ,
                        { 0, 0, 1, 1} };
        listStruct.Add(2, tab2);

        int[,] tab3 = { { 1, 1, 0, 0} ,
                        { 1, 1, 1, 0} ,
                        { 1, 0, 1, 1} ,
                        { 0, 1, 0, 1} };
        listStruct.Add(3, tab3);

        int[,] tab4 = { { 0, 1, 0, 0, 1, 1, 0, 0} ,
                        { 1, 1, 0, 1, 1, 1, 0, 1} ,
                        { 1, 1, 1, 1, 1, 1, 1, 0} ,
                        { 1, 1, 1, 0, 1, 1, 0, 0} ,
                        { 1, 0, 1, 1, 0, 0, 0, 1} ,
                        { 1, 1, 1, 0, 0, 1, 0, 0} ,
                        { 1, 0, 1, 1, 0, 1, 1, 1} ,
                        { 0, 1, 0, 1, 1, 0, 1, 1} };
        listStruct.Add(4, tab4);

        int[,] tab5 = { { 0, 1, 1, 1, 1, 0, 0, 0} ,
                        { 1, 1, 1, 0, 0, 0, 0, 0} ,
                        { 1, 1, 0, 0, 1, 1, 0, 0} ,
                        { 1, 1, 0, 1, 1, 1, 1, 0} ,
                        { 1, 1, 0, 1, 0, 0, 1, 0} ,
                        { 0, 1, 1, 0, 0, 0, 1, 0} ,
                        { 0, 0, 1, 1, 1, 1, 0, 0} ,
                        { 0, 0, 0, 1, 1, 0, 0, 0} };
        listStruct.Add(5, tab5);

        int[,] tab6 = { { 0, 0, 0, 1, 1, 0, 0, 0} ,
                        { 0, 0, 0, 0, 0, 0, 0, 0} ,
                        { 1, 0, 0, 0, 0, 0, 0, 1} ,
                        { 1, 1, 1, 1, 1, 1, 1, 1} ,
                        { 1, 1, 1, 1, 1, 1, 1, 1} ,
                        { 1, 0, 0, 0, 0, 0, 0, 1} ,
                        { 0, 0, 0, 0, 0, 0, 0, 0} ,
                        { 0, 0, 0, 1, 1, 0, 0, 0} };
        listStruct.Add(6, tab6);

        int[,] tab7 = { { 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0} ,
                        { 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0} ,
                        { 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0} ,
                        { 1, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1} ,
                        { 1, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 1, 1, 1, 1, 1} ,
                        { 1, 0, 1, 1, 1, 1, 1, 0, 1, 0, 1, 1, 0, 0, 0, 0} ,
                        { 0, 0, 1, 1, 0, 1, 1, 0, 0, 0, 0, 1, 1, 1, 1, 0} ,
                        { 1, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1} ,
                        { 1, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1} ,
                        { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 1, 1, 0} ,
                        { 1, 0, 0, 1, 1, 1, 1, 0, 0, 0, 1, 0, 0, 1, 0, 1} ,
                        { 1, 0, 0, 1, 1, 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 1} ,
                        { 1, 1, 1, 1, 1, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 1} ,
                        { 1, 0, 0, 0, 1, 1, 1, 1, 1, 0, 1, 1, 0, 1, 1, 1} ,
                        { 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0} ,
                        { 1, 0, 0, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 0, 1} };
        listStruct.Add(7, tab7);

        int[,] tab8 = { { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1} ,
                        { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1} ,
                        { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1} ,
                        { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1} ,
                        { 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1} ,
                        { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1} ,
                        { 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1} ,
                        { 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1} ,
                        { 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1} ,
                        { 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0} ,
                        { 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1} ,
                        { 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1} ,
                        { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1} ,
                        { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1} ,
                        { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1} ,
                        { 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1} };
        listStruct.Add(8, tab8);

    }

    public Dictionary<int, int[,]> getList()
    {
        return listStruct;
    }

}