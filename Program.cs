// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using mod5_1302223148.Penjumlahan;
using mod5_1302223148.SimpleDataBase;
public class Program
{
    public static void Main (string[] args)
    {
    Penjumlahan<int> jum = new Penjumlahan<int>();
        jum.jumlahTigaAngka(22,31,48);

    SimpleDataBase<int> data = new SimpleDataBase<int>();
        data.addNewData(22);
        data.addNewData(31);
        data.addNewData(48);

        data.PrintAllData();
    }
}
