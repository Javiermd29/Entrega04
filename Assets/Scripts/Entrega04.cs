using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entrega04 : MonoBehaviour
{
    //Exercise 1
    [SerializeField] private float num1;
    [SerializeField] private float num2;

    //Exercise 2
    [SerializeField] private string letter = "b";

    //Exercise 3/5/6
    [SerializeField] private int day;
    [SerializeField] private int month;
    [SerializeField] private int year;

    //Exercise 4
    [SerializeField] private int LeapYear;

    //Exercise 7
    [SerializeField] private int ChineseYear;

    //Exercise 8
    [SerializeField] private float base8;
    [SerializeField] private float height;

    //Exercise 9
    [SerializeField] private float grade;

    //Exercise 10
    [SerializeField] private int EvenOdd;

    void Start()
    {
        ex1(7, 9);
        ex2();
        ex3(-2, 2, 1997);
        ex4(1996);
        ex5(31, 12, 1997);
        ex6(1, 1, 1998);
        ex7(1997);
        ex8(3.8f, 16.8f);
        ex9(8.2f);
        ex10(222);
    }

    void Update()
    {

    }

    private void ex1(float num1, float num2)
    {

        if (num1 < num2)
        {
            Debug.Log(num1);
        }
        else
        {
            Debug.Log(num2);
        }

    }

    private void ex2()
    {

        bool vowel_consonant = false;

        if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u" )
        {
            vowel_consonant = true;
        }

        Debug.Log(vowel_consonant);

    }

    private void ex3(int day, int month, int year)
    {

        if ((day >= 1 && day <= 31) && (month >= 1 && month <= 12) && (year >= 1))
        {
            Debug.Log(day + "/" + month + "/" + year + " es una fecha válida");
        }
        else
        {
            Debug.Log(day + "/" + month + "/" + year + " no es una fecha válida");
        }

    }

    private void ex4(int LeapYear)
    {

        if (((LeapYear % 4 == 0) && (LeapYear % 100 != 0)) || (LeapYear % 400 == 0))
        {
            Debug.Log(LeapYear + " es un año bisiesto");
        }
        else
        {
            Debug.Log(LeapYear + " no es un año bisiesto");
        }

    }

    private void ex5(int day, int month, int year)
    {

        if ((month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10) && day == 31)
        {
            day = 1;
            month = month + 1;
            Debug.Log(day + "/" + month + "/" + year);
        } else if ((month == 4 || month == 6 || month == 9 || month == 11) && day == 30)
        {
            day = 1;
            month = month + 1;
            Debug.Log(day + "/" + month + "/" + year);
        } else if (month == 2 && day == 28)
        {
            day = 1;
            month = month + 1;
            Debug.Log(day + "/" + month + "/" + year);
        } else if (month == 12 && day == 31)
        {
            day = 1;
            month = 1;
            year = year + 1;
            Debug.Log(day + "/" + month + "/" + year);
        }
        else
        {
            day = day + 1;
            Debug.Log(day + "/" + month + "/" + year);
        }

    }

    private void ex6(int day, int month, int year)
    {

        if ((month == 2 || month == 4 || month == 6 || month == 8 || month == 9 || month == 11) && day == 1)
        {
            day = 31;
            month = month -1;
            Debug.Log(day + "/" + month + "/" + year);
        }
        else if ((month == 5 || month == 7 || month == 10 || month == 12) && day == 1)
        {
            day = 30;
            month = month -1;
            Debug.Log(day + "/" + month + "/" + year);
        }
        else if (month == 3 && day == 1)
        {
            day = 28;
            month = month - 1;
            Debug.Log(day + "/" + month + "/" + year);
        }
        else if (month == 1 && day == 1)
        {
            day = 31;
            month = 12;
            year = year - 1;
            Debug.Log(day + "/" + month + "/" + year);
        }
        else
        {
            day = day - 1;
            Debug.Log(day + "/" + month + "/" + year);
        }

    }

    private void ex7(int ChineseYear)
    {

        switch (ChineseYear)
        {
            case 0:
                Debug.Log("Mono");
                break;
            case 1:
                Debug.Log("Gallo");
                break;
            case 2:
                Debug.Log("Perro");
                break;
            case 3:
                Debug.Log("Cerdo");
                break;
            case 4:
                Debug.Log("Rata");
                break;
            case 5:
                Debug.Log("Buey");
                break;
            case 6:
                Debug.Log("Tigre");
                break;
            case 7:
                Debug.Log("Conejo");
                break;
            case 8:
                Debug.Log("Dragón");
                break;
            case 9:
                Debug.Log("Serpiente");
                break;
            case 10:
                Debug.Log("Caballo");
                break;
            case 11:
                Debug.Log("Cabra");
                break;
        }

    }

    private void ex8(float base8, float height)
    {

        float result = (base8 * height) / 2;

        if (base8 > 0 && height > 0)
        {
            Debug.Log("El área del triángulo es: " + result);
        }

    }

    private void ex9(float grade)
    {

        if (grade < 0 || grade > 10)
        {
            Debug.Log("La nota no es válida");
        }
        if (grade >= 9)
        {
            Debug.Log("A");
        }
        else if (grade >= 7)
        {
            Debug.Log("B");
        }
        else if (grade >= 5)
        {
            Debug.Log("C");
        }
        else
        {
            Debug.Log("D");
        }

    }

    private void ex10(int EvenOdd)
    {

        if (EvenOdd % 2 == 0)
        {
            Debug.Log(EvenOdd + " es par");
        }
        else
        {
            Debug.Log(EvenOdd + " es impar");
        }

    }

}
