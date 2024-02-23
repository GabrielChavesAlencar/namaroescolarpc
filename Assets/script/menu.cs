using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public int cont;
    public int contador;
    public Text texto;
    public Sprite[] sprites;
    public Image garota;
    public GameObject[] menus;



    public int numerodaimagem;
    public float numerador;
    public float coralfa;


    public RectTransform retgarotas;


    public Image [] garotamenu;







    //variaveis do load
    public static string[] p;
    public static int[] p1;
    public static int c;
    public static int comeco;


    public Image[] imagembotao;
    public Text[] textosave;
    public Color corcarregar;




    // Start is called before the first frame update
    void Start()
    {
        
        contador = 0;
        cont = 0;
        numerador = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        garotamenu[numerodaimagem].color = new Color(1, 1, 1, coralfa);
        coralfa += Time.deltaTime * numerador;
        if (coralfa > 2) { numerador = -0.5f; }
        if (coralfa < -1) { numerador = 0.5f; numerodaimagem++; }
        if (numerodaimagem > 3) { numerodaimagem = 0; }
        if (contador == 0)
        {
            retgarotas.sizeDelta = new Vector2(344, 780);
            garota.sprite = sprites[0];texto.text= "Ana é uma garota tímida, inteligente" +
                " e meiga. Gosta de animes e games." +
                " Ela é baixa e mede cerca de 1,59 de altura" +
                ", faz faculdade de comercio do exterior o mesmo do protagonista.";
                
        }

        if (contador == 1)
        {
            retgarotas.sizeDelta = new Vector2(280, 815);
            garota.sprite = sprites[1]; texto.text = "Aisha é uma mulher forte e" +
                 " guerreira, extrovertida e porem uma pessoa dificil de se lidar. Ela é alta e " +
                 "mede cerca de 1,72,adora correr e fazer academia " +
                 " e por isso possui um corpo digno de uma modelo.";

        }

        if (contador == 2)
        {
            retgarotas.sizeDelta = new Vector2(344, 780);
            garota.sprite = sprites[2]; texto.text = "Bianca é garota agressiva com personalidade " +
                "forte que sempre fala o que pensa, uma amante de música e filmes. Ela mede cerca " +
                "de 1,65 Ela adora andar com roupas escuras, braceletes e colares.";

        }

        if (contador == 3)
        {
            retgarotas.sizeDelta = new Vector2(280, 780);
            garota.sprite = sprites[3]; texto.text = "Luna é uma garota tímida e generosa, sempre" +
                " busca ajudar aos que precisam e principalmente os animais. Uma amiga de infância do protagonista" +
                " cozinhar e assistir filmes, mede cerca de 1,60 " +
                "adora fazer piadinhas de duplo sentido com ele.";

        }







        if (cont == 0) { menus[0].SetActive(true); }
        else { menus[0].SetActive(false); }
        if (cont == 1) { menus[1].SetActive(true); }
        else { menus[1].SetActive(false); }
        if (cont == 2) { menus[2].SetActive(true); }
        else { menus[2].SetActive(false); }
        if (cont == 3) { menus[3].SetActive(true); }
        else { menus[3].SetActive(false); }
    }


    public void garotas() { cont = 1; }
    public void creditos() { cont = 2; }
    public void comecar() { SceneManager.LoadScene("jogo"); }
    public void voltar() { cont = 0; }
    public void setmais() { contador--;if (contador  < 0) contador = 3; }
    public void setmenos() { contador++; if (contador >3) contador = 0; }
    public void sair() { Application.Quit(); }
    public void continuar() { 
        cont = 3;
        for (int i = 0; i < imagembotao.Length; i++) { imagembotao[i].color = corcarregar; textosave[i].text = bancodedados.carregardata(i); }
    }
    public void load(int numero)
    {
        dialogo.p = new string[3];
        dialogo.p1 = new int[3];
        dialogo.comeco = bancodedados.carregarsave(numero);
        // nome da personagem de cada uma das 3 da tela
        dialogo.p[0] = bancodedados.carregarnomes(numero)[0];
        dialogo.p[1] = bancodedados.carregarnomes(numero)[1];
        dialogo.p[2] = bancodedados.carregarnomes(numero)[2];
        //emoção de cada uma
        dialogo.p1[0] = bancodedados.carregaremocoes(numero)[0];
        dialogo.p1[1] = bancodedados.carregaremocoes(numero)[1];
        dialogo.p1[2] = bancodedados.carregaremocoes(numero)[2];

        //cenario
        dialogo.c = bancodedados.carregarcenario(numero);
        SceneManager.LoadScene("jogo");
    }
}
