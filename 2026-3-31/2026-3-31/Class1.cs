using System;
using static System.Net.Mime.MediaTypeNames;

public class Student
{
    private int ID;
    private string Name;
    private Test Score; // 假設有一個 Test 類別處理成績

    public static int count; // 靜態變數，用於記錄實例化的次數

    public Student(int id, string n, int m, int f)
    {
        ID = id;
        Name = n;
        Score = new Test(m, f); // 建立 Test 物件實例
        count++; // 每建立一個學生，計數器加 1
    }

    public string GetStudent()
    {
        string str;
        str = "學生編號: " + ID.ToString();
        str += "\n學生姓名: " + Name;
        str += "\n期中考成績: " + Score.GetMid().ToString();
        str += "\n期末考成績: " + Score.GetFinal().ToString();
        str += "\n平均成績: " + Score.GetAvg().ToString();
        return str;
    }
}