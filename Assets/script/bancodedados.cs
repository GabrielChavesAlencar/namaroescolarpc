using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class bancodedados
{
    public static void sarvar(int numero, int dado)
    {
        PlayerPrefs.SetInt("pontos" + numero, dado);

    }
    public static int carregarsave(int numero)
    {
        int salvo = PlayerPrefs.GetInt("pontos" + numero, 0);
        return salvo;
    }



    public static void sarvar2(string p1, string p2, string p3, int emo1, int emo2, int emo3, int cenario, int numero)
    {
        PlayerPrefs.SetInt("emo1" + numero, emo1);
        PlayerPrefs.SetInt("emo2" + numero, emo1);
        PlayerPrefs.SetInt("emo2" + numero, emo3);
        PlayerPrefs.SetInt("cenario" + numero, cenario);
        PlayerPrefs.SetString("per1" + numero, p1);
        PlayerPrefs.SetString("per2" + numero, p2);
        PlayerPrefs.SetString("per3" + numero, p3);
        
    }
    public static string[] carregarnomes(int numero)
    {
        string[] h = new string[3];
        h[0] = PlayerPrefs.GetString("per1" + numero);
        h[1] = PlayerPrefs.GetString("per2" + numero);
        h[2] = PlayerPrefs.GetString("per3" + numero);
        return h;
    }

    public static int carregarcenario(int numero)
    {
        int salvo = PlayerPrefs.GetInt("cenario" + numero, 0);
        return salvo;
    }
    public static int[]carregaremocoes(int numero)
    {
        int[] j = new int[3];
        j[0] = PlayerPrefs.GetInt("emo1" + numero,0);
        j[1] = PlayerPrefs.GetInt("emo2" + numero,0);
        j[2] = PlayerPrefs.GetInt("emo3" + numero,0);
        return j;
    }

    public static void salvardata(int numero,string texto) 
    {
        PlayerPrefs.SetString("data" + numero,texto);
    }
    public static string carregardata(int numero) 
    {
        return PlayerPrefs.GetString("data" + numero,"save "+(numero+1)+": "); 
    }



    public static void salvarfala(int indice, int num)
    {
        PlayerPrefs.SetInt("fala" + indice, num);
    }
    public static int carregarfala(int indice)
    {
        return PlayerPrefs.GetInt("fala" + indice);
    }
}
