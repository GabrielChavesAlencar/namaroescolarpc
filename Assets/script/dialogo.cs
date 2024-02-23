using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class dialogo : MonoBehaviour
{
    public int contads;
    public TextAsset dialog;
    public Text txt;
    public Animator anim;

    public Text nomepersonagem;
    public GameObject botoes;
    public GameObject botaodialogo;
    private int selected;
    public string str;
    public bool escrevendo;
    public float cooldown;
    public int mudanca;

    //teste de variaveis pra achar mais rapido o erro no for do dialogo
    public char test1;
    public char test2;
    public char test3;

    
    //opicoes de rota
    public GameObject opcaorota;
    public GameObject opcao2rota;
    public int[] valordarota;
    public string stringderota;
    public string stringderota2;
    public bool carregar;

    //texto das opicoes 1
    public Text op1;
    public Text op2;

    //texto das opicoes 2
    public Text op3;
    public Text op4;
    public Text op5;



   public Sprite[] luna;
   public Sprite[] lunadelado;
   public Sprite[] ana;
   public Sprite[] anadelado;
   public Sprite[] bianca;
   public Sprite[] biancadelado;
   public Sprite[] aisha;
   public Sprite[] aishadelado;
   public Sprite[] irma;
   public Sprite[] irmadelado;
   public Sprite[] pedro;
   public Sprite[] pedrodelado;
   public Sprite[] mae;
   public Sprite[] maedelado;

    public InterstitialAdExample videoADS;



    //tamanho do quadrado da direita
    public float quaqedireitax, quaqdireitay;

    //tamanho do quadrado da esquerda
    public float quaqesquerdax, quaqesquerday;


    public Sprite spritedefalt;

   public string spritetemp;
   public Image[] garotap;

    public GameObject[] cenario;
    public static int cenarioestatico;
    public bool mudarcenario;
    public int numerocenario;
    public int ladodopersonagem;


    public static  string[] p;
    public static int[] p1;
    public static int c;

    public Image telapreta;
    public float contagemtelapreta;
    public bool telapretamudanca;

    public RectTransform retgarota1;
    public RectTransform retgarota2;
    public RectTransform retgarota3;

    public float inverter;
    public int numerodorect;

    public static int comeco;


    public int a;

    //TEXTO SAVE
    public GameObject objetodosave;
    public Text [] textosave;
    public Color corsalvar;
    public Color corcarregar;


    public Image [] imagembotao;
    public bool menudosave;

    private void Start()

    {
       
        inverter = 1;
        telapreta.color = new Color(0, 0, 0, 1);
        
        menudosave = false;
        carregar = false;
        nomepersonagem.text = "";
        valordarota = new int[3];
        if (p==null)p = new string[3];
        if (p1 == null) p1 = new int[3];
        numerocenario = c;
        //luna
        if (p[0] == "l") {garotap[0].sprite = luna[p1[0]];}
        if (p[1] == "l") {garotap[1].sprite = luna[p1[1]];}
        if (p[2] == "l") {garotap[2].sprite = luna[p1[2]];}

        //luna de lado
        if (p[0] == "L") { garotap[0].sprite = lunadelado[p1[0]]; }
        if (p[1] == "L") { garotap[1].sprite = lunadelado[p1[1]]; }
        if (p[2] == "L") { garotap[2].sprite = lunadelado[p1[2]]; }


        //ana
        if (p[0] == "a") { garotap[0].sprite = ana[p1[0]]; }
        if (p[1] == "a") { garotap[1].sprite = ana[p1[1]]; }
        if (p[2] == "a") { garotap[2].sprite = ana[p1[2]]; }

        //anadelado
        if (p[0] == "A") { garotap[0].sprite = anadelado[p1[0]]; }
        if (p[1] == "A") { garotap[1].sprite = anadelado[p1[1]]; }
        if (p[2] == "A") { garotap[2].sprite = anadelado[p1[2]]; }


        //bianca
        if (p[0] == "b") { garotap[0].sprite = bianca[p1[0]]; }
        if (p[1] == "b") { garotap[1].sprite = bianca[p1[1]]; }
        if (p[2] == "b") { garotap[2].sprite = bianca[p1[2]]; }


        //biancadelado
        if (p[0] == "B") { garotap[0].sprite = biancadelado[p1[0]]; }
        if (p[1] == "B") { garotap[1].sprite = biancadelado[p1[1]]; }
        if (p[2] == "B") { garotap[2].sprite = biancadelado[p1[2]]; }


        //aisha
        if (p[0] == "s") { garotap[0].sprite = aisha[p1[0]]; }
        if (p[1] == "s") { garotap[1].sprite = aisha[p1[1]]; }
        if (p[2] == "s") { garotap[2].sprite = aisha[p1[2]]; }

        //aishadelado
        if (p[0] == "S") { garotap[0].sprite = aishadelado[p1[0]]; }
        if (p[1] == "S") { garotap[1].sprite = aishadelado[p1[1]]; }
        if (p[2] == "S") { garotap[2].sprite = aishadelado[p1[2]]; }


        //irma
        if (p[0] == "i") { garotap[0].sprite = irma[p1[0]]; }
        if (p[1] == "i") { garotap[1].sprite = irma[p1[1]]; }
        if (p[2] == "i") { garotap[2].sprite = irma[p1[2]]; }

        //irmadelado
        if (p[0] == "I") { garotap[0].sprite = irmadelado[p1[0]]; }
        if (p[1] == "I") { garotap[1].sprite = irmadelado[p1[1]]; }
        if (p[2] == "I") { garotap[2].sprite = irmadelado[p1[2]]; }


        //Pedro
        if (p[0] == "q") { garotap[0].sprite = pedro[p1[0]]; }
        if (p[1] == "q") { garotap[1].sprite = pedro[p1[1]]; }
        if (p[2] == "q") { garotap[2].sprite = pedro[p1[2]]; }

        //Pedrodelado
        if (p[0] == "Q") { garotap[0].sprite = pedrodelado[p1[0]]; }
        if (p[1] == "Q") { garotap[1].sprite = pedrodelado[p1[1]]; }
        if (p[2] == "Q") { garotap[2].sprite = pedrodelado[p1[2]]; }

        //Mae
        if (p[0] == "m") { garotap[0].sprite = mae[p1[0]]; }
        if (p[1] == "m") { garotap[1].sprite = mae[p1[1]]; }
        if (p[2] == "m") { garotap[2].sprite = mae[p1[2]]; }

        //Maedelado
        if (p[0] == "M") { garotap[0].sprite = maedelado[p1[0]]; }
        if (p[1] == "M") { garotap[1].sprite = maedelado[p1[1]]; }
        if (p[2] == "M") { garotap[2].sprite = maedelado[p1[2]]; }















        garotap[0].sprite = spritedefalt;
        garotap[1].sprite = spritedefalt;
        garotap[2].sprite = spritedefalt;
        mudanca = 0;
        showDialog();
        
        mudarcenario = true;
       
    }
    private void Update()
    {
        
        //tela preta pra mucança de cenario
        telapreta.color = new Color(0, 0, 0, contagemtelapreta);
        if (telapretamudanca) 
        {
           
           contagemtelapreta += Time.deltaTime*inverter*0.5f; 
            
            if (contagemtelapreta >= 1 && inverter == 1) 
            { //inverter = -1;
                 StartCoroutine(invertercontagem());
               
            }
            if (contagemtelapreta > 1 && inverter == -1&& contagemtelapreta < 1.2f)
            {
                 contagemtelapreta = 0.99f; mudanca = 0; nextDialog();
            }
            if (contagemtelapreta < 0) 
            {
                //nextDialog();
                botaodialogo.SetActive(true);

                telapretamudanca = false;
               

            }
        }






     //   textosave[0].text = "SAVE 1: " + "\n" + "DATA: " + System.DateTime.Now.ToString("dd/MM/yyyy") +"\n"+ "HORA: " + System.DateTime.Now.ToString("HH:mm:ss");
        if (mudarcenario) 
        {
            for (int i = 0; i < cenario.Length; i++)
            {
                if (i == numerocenario) { cenario[i].SetActive(true); }
                else { cenario[i].SetActive(false); }
            }
            mudarcenario = false;
        }
        
    }
    public void showDialog() 
    {
        // anim.SetTrigger("open");
        selected = comeco;
        str = dialog.text.Split('\n')[selected];
        loadLetters();
       

    }
    public void nextDialog()
    {
        if (selected < dialog.text.Split('\n').Length-1)
        {

            StopAllCoroutines();
            contads++;
            /*
            if (contads > 20 && contads < 22) { videoADS.LoadAd();contads = 22; }
            if (contads > 40) { videoADS.ShowAd();contads = 0;videoADS.videoload = false; }
            */
           // Debug.Log(contads);
            selected++;
                escrevendo = true;
                str = dialog.text.Split('\n')[selected];
                loadLetters();
            

        }
    }
    public void loadLetters() 
    {
        
        txt.text = "";
        char[] chars = str.ToCharArray();

        for (int i = 0; i < chars.Length; i++) 
        {
                //trocar persongem
                if (chars[i] == '(') { mudanca = 1; }
                if (chars[i] == ')') { mudanca = 30; }
                if (chars[i] == '%') { mudanca = 10; }
                


                //efeitode troca de cenario
                 if (chars[i] == '|') { mudanca = 40; }
                 //trocar cenario
                 if (chars[i] == '*') { mudanca = 4; }

                //opcoes de rota
                if (chars[i] == '[') { if (mudanca == 10) { mudanca = 11; } if (mudanca == 15) { mudanca = 16; } }
                if (chars[i] == ']') {  mudanca = 13;}
                if (chars[i] == '{') {  mudanca = 18;}
                if (chars[i] == '}') {   mudanca = 21;}
            if (mudanca == 40)
            {
                chars[i] = ' ';
                botaodialogo.SetActive(false);
                mudancadecena();
                mudanca = 41;
            }
         

            




            if (mudanca == 31)
            {
                if (chars[i] == 'a') { chars[i] = 'ã'; }
                if (chars[i] == 'i') { chars[i] = 'í'; }
                if (chars[i] == 'A') { chars[i] = 'á'; }
                if (chars[i] == 'e') { chars[i] = 'é'; }
                if (chars[i] == 'E') { chars[i] = 'ê'; }
                if (chars[i] == 'c') { chars[i] = 'ç'; }
                if (chars[i] == 'd') { chars[i] = '%'; }
                if (chars[i] == 'o') { chars[i] = 'ó'; }
                if (chars[i] == 'U') { chars[i] = 'õ'; }
                mudanca = 0;
            }
                if (mudanca == 30)
            {
                chars[i] = ' ';
                
                
                mudanca = 31; 
            }
                //rotas opicao 1
                if (mudanca == 11)
            {
                stringderota2 = "";
                stringderota = dialog.text.Split('\n')[selected];
                stringderota2 += stringderota[1];
                stringderota2 += stringderota[2];
                stringderota2 += stringderota[3];
                mudanca = 12;
            }
            //rotas opicao 1
            if (mudanca == 12) 
            {
               valordarota[0]= int.Parse(stringderota2);
                mudanca = 10;
                nextDialog();
                

            }

            //rotas opicao 1
            if (mudanca == 13)
            {
                stringderota2 = "";
                stringderota = dialog.text.Split('\n')[selected];
                stringderota2 += stringderota[1];
                stringderota2 += stringderota[2];
                stringderota2 += stringderota[3];
                mudanca = 14;
            }
            //rotas opicao 1
            if (mudanca == 14)
            {
                valordarota[1] = int.Parse(stringderota2);
               // nextDialog();
            }



            //rotas opicao 2
            if (mudanca == 16)
            {
                selected++;
                stringderota2 = "";
                stringderota = dialog.text.Split('\n')[selected];
                stringderota2 += stringderota[1];
                stringderota2 += stringderota[2];
                stringderota2 += stringderota[3];
                mudanca = 17;
            }
            //rotas opicao 2
            if (mudanca == 17)
            {
                valordarota[0] = int.Parse(stringderota2);
                mudanca = 20;
                nextDialog();


            }

            //rotas opicao 2
            if (mudanca == 18)
            {
                stringderota2 = "";
                stringderota = dialog.text.Split('\n')[selected];
                stringderota2 += stringderota[1];
                stringderota2 += stringderota[2];
                stringderota2 += stringderota[3];
                mudanca = 19;
            }
            //rotas opicao 2
            if (mudanca == 19)
            {
                valordarota[1] = int.Parse(stringderota2);
                mudanca = 20;
               // nextDialog();
            }


            //rotas opicao 2
            if (mudanca == 21)
            {
                stringderota2 = "";
                stringderota = dialog.text.Split('\n')[selected];
                stringderota2 += stringderota[1];
                stringderota2 += stringderota[2];
                stringderota2 += stringderota[3];
                selected++;
                mudanca = 22;
            }
            if (mudanca == 22)
            {
                valordarota[2] = int.Parse(stringderota2);

            }



            //rotas2
            if (mudanca == 20)
            {
                if (chars[i] == '1') { op3.text = dialog.text.Split('\n')[selected-3]; nextDialog(); }
                if (chars[i] == '2') { op4.text = dialog.text.Split('\n')[selected]; nextDialog(); }
                if (chars[i] == '3') { op5.text = dialog.text.Split('\n')[selected]; nextDialog(); }
            }





            //rotas
            if (mudanca==10) { 
               
                botaodialogo.SetActive(false);
                if (chars[i] == 'a') { opcaorota.SetActive(true);nextDialog(); }
                if (chars[i] == 'b') { opcao2rota.SetActive(true); mudanca = 16; nextDialog(); }
                if (chars[i] == '1') { op1.text = dialog.text.Split('\n')[selected]; nextDialog(); }
                if (chars[i] == '2') { op2.text = dialog.text.Split('\n')[selected]; }

                
            }




            //comecar a escrever em velocidade reduzida
            if (mudanca == 0)
            {
                StartCoroutine(getLetter(chars[i], i));
            }
            if (mudanca == 1)
            {
               test1 = chars[i];
                i++;
                ladodopersonagem = int.Parse(chars[i] + "");
                mudanca =2;

            }

            //mudar personagem
            if (mudanca==2) 
            {
                i++;
                test2 = chars[i];
                p[ladodopersonagem] = chars[i]+"";
                if (chars[i] == 'l') { spritetemp = "luna";nomepersonagem.text = "Luna"; mudanca = 3; }
                if (chars[i] == 'L') { spritetemp = "lunadelado"; mudanca = 3; nomepersonagem.text = "Luna"; }
                if (chars[i] == 'a') { spritetemp = "ana"; mudanca = 3; nomepersonagem.text = "Ana"; }
                if (chars[i] == 'A') { spritetemp = "anadelado"; mudanca = 3; nomepersonagem.text = "Ana"; }
                if (chars[i] == 'b') { spritetemp = "bianca"; mudanca = 3; nomepersonagem.text = "Bianca"; }
                if (chars[i] == 'B') { spritetemp = "biancadelado"; mudanca = 3; nomepersonagem.text = "Bianca"; }
                if (chars[i] == 's') { spritetemp = "aisha"; mudanca = 3; nomepersonagem.text = "Aisha"; }
                if (chars[i] == 'S') { spritetemp = "aishadelado"; mudanca = 3; nomepersonagem.text = "Aisha"; }
                if (chars[i] == 'i') { spritetemp = "irma"; mudanca = 3; nomepersonagem.text = "Lily"; }
                if (chars[i] == 'I') { spritetemp = "irmadelado"; mudanca = 3; nomepersonagem.text = "Lily"; }
                if (chars[i] == 'q') { spritetemp = "pedro"; mudanca = 3; nomepersonagem.text = "Pedro"; }
                if (chars[i] == 'Q') { spritetemp = "pedrodelado"; mudanca = 3; nomepersonagem.text = "Pedro"; }
                if (chars[i] == 'm') { spritetemp = "mae"; mudanca = 3; nomepersonagem.text = "Mãe"; }
                if (chars[i] == 'M') { spritetemp = "maedelado"; mudanca = 3; nomepersonagem.text = "Mãe"; }
                if (chars[i] == '@') { garotap[ladodopersonagem].sprite = spritedefalt; mudanca = 0; nomepersonagem.text = ""; }
                if (chars[i] == 'P') { garotap[ladodopersonagem].sprite = spritedefalt; mudanca = 0; nomepersonagem.text = "EU"; }
               // if (chars[i] == 'M') { garotap[ladodopersonagem].sprite = spritedefalt; mudanca = 0; nomepersonagem.text = "Mãe"; }
                if (chars[i] == 'C') { garotap[ladodopersonagem].sprite = spritedefalt; mudanca = 0; nomepersonagem.text = "Cara"; }
                if (chars[i] == 'H') { garotap[ladodopersonagem].sprite = spritedefalt; mudanca = 0; nomepersonagem.text = "Homen estranho"; }
                if (chars[i] == 'W') { garotap[ladodopersonagem].sprite = spritedefalt; mudanca = 0; nomepersonagem.text = "Mulher estranha"; }
                if (chars[i] == 'c') { garotap[ladodopersonagem].sprite = spritedefalt; mudanca = 0; nomepersonagem.text = "Sr. Carlos"; }
                if (chars[i] == 'n') { garotap[ladodopersonagem].sprite = spritedefalt; mudanca = 0; nomepersonagem.text = "Sra. Maria"; }
                if (chars[i] == '?') { garotap[ladodopersonagem].sprite = spritedefalt; mudanca = 0; nomepersonagem.text = "????"; }
                
                // i++;


              //  mudanca = 3;


            }
            if (mudanca == 3)
            {
                //   
                i++;
                test3 = chars[i];
                a = int.Parse(chars[i]+"");
                p1[ladodopersonagem] = a;
                if (spritetemp == "luna") { garotap[ladodopersonagem].sprite = luna[a];numerodorect = 1; }
                if (spritetemp == "lunadelado") { garotap[ladodopersonagem].sprite = lunadelado[a]; numerodorect = 1; }
                if (spritetemp == "ana") { garotap[ladodopersonagem].sprite = ana[a]; numerodorect = 2; }
                if (spritetemp == "anadelado") { garotap[ladodopersonagem].sprite = anadelado[a]; numerodorect = 2; }
                if (spritetemp == "bianca") { garotap[ladodopersonagem].sprite = bianca[a]; numerodorect = 2; }
                if (spritetemp == "biancadelado") { garotap[ladodopersonagem].sprite = biancadelado[a]; numerodorect = 3; }
                if (spritetemp == "aisha") { garotap[ladodopersonagem].sprite = aisha[a]; numerodorect = 4; }
                if (spritetemp == "aishadelado") { garotap[ladodopersonagem].sprite = aishadelado[a]; numerodorect = 5; }
                if (spritetemp == "irma") { garotap[ladodopersonagem].sprite = irma[a]; numerodorect = 4; }
                if (spritetemp == "irmadelado") { garotap[ladodopersonagem].sprite = irmadelado[a]; numerodorect = 4; }
                if (spritetemp == "pedro") { garotap[ladodopersonagem].sprite = pedro[a]; numerodorect = 6; }
                if (spritetemp == "pedrodelado") { garotap[ladodopersonagem].sprite = pedrodelado[a]; numerodorect = 6; }

                if (spritetemp == "mae") { garotap[ladodopersonagem].sprite = mae[a]; numerodorect = 1; }
                if (spritetemp == "maedelado") { garotap[ladodopersonagem].sprite = maedelado[a]; numerodorect = 1; }
                if (numerodorect == 1) 
                {
                    if (ladodopersonagem == 0) { retgarota1.sizeDelta = new Vector2(280, 780); }
                    if (ladodopersonagem == 1) { retgarota2.sizeDelta = new Vector2(280, 780); retgarota2.localScale = new Vector2(1.3f, 1.3f); }
                    if (ladodopersonagem == 2) { retgarota3.sizeDelta = new Vector2(280, 780); retgarota3.localScale = new Vector2(-1.3f, 1.3f); }

                }
                if (numerodorect == 2) 
                {
                    if (ladodopersonagem == 0) { retgarota1.sizeDelta = new Vector2(334, 780); }
                    if (ladodopersonagem == 1) { retgarota2.sizeDelta = new Vector2(334, 780); retgarota2.localScale = new Vector2(1.3f, 1.3f); }
                    if (ladodopersonagem == 2) { retgarota3.sizeDelta = new Vector2(334, 780); retgarota3.localScale = new Vector2(-1.3f, 1.3f); }

                }
                if (numerodorect == 3)
                {
                    if (ladodopersonagem == 0) { retgarota1.sizeDelta = new Vector2(489, 780); }
                    if (ladodopersonagem == 1) { retgarota2.sizeDelta = new Vector2(465, 742); retgarota2.localPosition = new Vector3(254, -248, 0); retgarota2.localScale = new Vector2(1.3f, 1.3f); }
                    if (ladodopersonagem == 2) { retgarota3.sizeDelta = new Vector2(465, 742); retgarota3.localPosition = new Vector3(-323, -248, 0); retgarota3.localScale = new Vector2(-1.3f, 1.3f); }

                }
                else 
                {
                    if (ladodopersonagem == 1) { retgarota2.localPosition = new Vector3(195, -248, 0); }
                    if (ladodopersonagem == 2) { retgarota3.localPosition = new Vector3(-164, -248, 0); }
                }
                if (numerodorect == 4)
                {
                    if (ladodopersonagem == 0) { retgarota1.sizeDelta = new Vector2(280, 815); }
                    if (ladodopersonagem == 1) { retgarota2.sizeDelta = new Vector2(280, 815); retgarota2.localScale = new Vector2(1.3f, 1.3f); }
                    if (ladodopersonagem == 2) { retgarota3.sizeDelta = new Vector2(280, 815); retgarota3.localScale = new Vector2(-1.3f, 1.3f); }

                }
                if (numerodorect == 5)
                {
                    if (ladodopersonagem == 0) { retgarota1.sizeDelta = new Vector2(280, 815); }
                    if (ladodopersonagem == 1) { retgarota2.sizeDelta = new Vector2(280, 815); retgarota2.localScale = new Vector2(-1.3f,1.3f); }
                    if (ladodopersonagem == 2) { retgarota3.sizeDelta = new Vector2(280, 815); retgarota3.localScale = new Vector2(1.3f, 1.3f); }


                }

                if (numerodorect == 6)
                {
                    if (ladodopersonagem == 0) { retgarota1.sizeDelta = new Vector2(395, 911); }
                    if (ladodopersonagem == 1) { retgarota2.sizeDelta = new Vector2(395, 911); retgarota2.localScale = new Vector2(1.3f, 1.3f); }
                    if (ladodopersonagem == 2) { retgarota3.sizeDelta = new Vector2(395, 911); retgarota3.localScale = new Vector2(-1.3f, 1.3f); }


                }

                //selected++;
                //i++;
                mudanca = 0;

            }

            //mudar cenario
            if (mudanca == 4)
            {
                i++;
                
                if (chars[i] == 'a') { numerocenario = 0; mudarcenario = true; }//cenario1 trem
                if (chars[i] == 'b') { numerocenario = 1; mudarcenario = true; }//cenario1b trem
                if (chars[i] == 'c') { numerocenario = 2; mudarcenario = true; }//cenario1c trem
                if (chars[i] == 'd') { numerocenario = 3; mudarcenario = true; }//cenario2 corredor
                if (chars[i] == 'e') { numerocenario = 4; mudarcenario = true; }//cenario2b corredor
                if (chars[i] == 'f') { numerocenario = 5; mudarcenario = true; }//cenario2c corredor
                if (chars[i] == 'g') { numerocenario = 6; mudarcenario = true; }//cenario3 faculda de frente
                if (chars[i] == 'h') { numerocenario = 7; mudarcenario = true; }//cenario3b faculda de frente
                if (chars[i] == 'i') { numerocenario = 8; mudarcenario = true; }//cenario4 sala de aula
                if (chars[i] == 'j') { numerocenario = 9; mudarcenario = true; }//cenario4b sala de aula
                if (chars[i] == 'k') { numerocenario = 10; mudarcenario = true; }//cenario4c sala de aula
                if (chars[i] == 'l') { numerocenario = 11; mudarcenario = true; }//cenario5 refeitorio
                if (chars[i] == 'm') { numerocenario = 12; mudarcenario = true; }//cenario5b refeitorio
                if (chars[i] == 'n') { numerocenario = 13; mudarcenario = true; }//cenario6 rua
                if (chars[i] == 'o') { numerocenario = 14; mudarcenario = true; }//cenario6b rua
                if (chars[i] == 'p') { numerocenario = 15; mudarcenario = true; }//cenario7 quarto
                if (chars[i] == 'q') { numerocenario = 16; mudarcenario = true; }//cenario7b quarto
                if (chars[i] == 'r') { numerocenario = 17; mudarcenario = true; }//cenario8 frente de casa
                if (chars[i] == 's') { numerocenario = 18; mudarcenario = true; }//cenario8b frente de casa
                if (chars[i] == 't') { numerocenario = 19; mudarcenario = true; }//cenario9 sala
                if (chars[i] == 'u') { numerocenario = 20; mudarcenario = true; }//cenario9b sala
                if (chars[i] == 'v') { numerocenario = 21; mudarcenario = true; }//cenario10parque
                if (chars[i] == 'w') { numerocenario = 22; mudarcenario = true; }//cenario10bparque
                if (chars[i] == 'x') { numerocenario = 23; mudarcenario = true; }//cenario10cparque
                if (chars[i] == 'y') { numerocenario = 24; mudarcenario = true; }//cenario11a 25 de março
                if (chars[i] == 'z') { numerocenario = 25; mudarcenario = true; }//cenario11b 25 de março
                if (chars[i] == 'A') { numerocenario = 26; mudarcenario = true; }//cenario11c 25 de março




                c = numerocenario;
                mudanca = 0;

            }

            //if (chars[i] == ')') { mudanca = 0; }

        }
       
    }
    IEnumerator invertercontagem() { yield return new WaitForSeconds(1);inverter = -1; }
    public void mudancadecena()
    {
        telapretamudanca = true;
        inverter = 1;
        
    }
    IEnumerator getLetter(char l,int x) 
    {
       
        yield return new WaitForSeconds(cooldown*x);
        txt.text += l.ToString();
        


    }

    public void quicksave() { 
        bancodedados.sarvar(0, selected);
        bancodedados.sarvar2(p[0], p[1], p[2], p1[0], p1[1], p1[2], c, 0);



    }
    public void quickload() { 
        //numero da linha do texto
        comeco = bancodedados.carregarsave(0);
       // nome da personagem de cada uma das 3 da tela
        p[0] = bancodedados.carregarnomes(0)[0];
        p[1] = bancodedados.carregarnomes(0)[1];
        p[2] = bancodedados.carregarnomes(0)[2];
        //emoção de cada uma
        p1[0] = bancodedados.carregaremocoes(0)[0];
        p1[1] = bancodedados.carregaremocoes(0)[1];
        p1[2] = bancodedados.carregaremocoes(0)[2];

        //cenario
        c = bancodedados.carregarcenario(0);
        SceneManager.LoadScene("jogo"); 
    }

    public void ocultarbotao() 
    {
        if (!menudosave) { botoes.SetActive(!botoes.activeInHierarchy); }
    }
    public void save(int numero) {

        if (!carregar)
        {
            bancodedados.salvardata(numero-1, "SAVE "+(numero)+": " + "\n" + "DATA: " + System.DateTime.Now.ToString("dd/MM/yyyy") + "\n" + "HORA: " + System.DateTime.Now.ToString("HH:mm:ss"));
            bancodedados.sarvar(numero, selected);
            bancodedados.sarvar2(p[0], p[1], p[2], p1[0], p1[1], p1[2], c, numero);



        }
        if (carregar)
        {
            //numero da linha do texto
            comeco = bancodedados.carregarsave(numero);
            // nome da personagem de cada uma das 3 da tela
            p[0] = bancodedados.carregarnomes(numero)[0];
            p[1] = bancodedados.carregarnomes(numero)[1];
            p[2] = bancodedados.carregarnomes(numero)[2];
            //emoção de cada uma
            p1[0] = bancodedados.carregaremocoes(numero)[0];
            p1[1] = bancodedados.carregaremocoes(numero)[1];
            p1[2] = bancodedados.carregaremocoes(numero)[2];

            //cenario
            c = bancodedados.carregarcenario(numero);
            SceneManager.LoadScene("jogo");
        }
        fecharmenusave();
    }
    public void mudarparasalvar() {
        carregar = false;objetodosave.SetActive(true);menudosave = true;botoes.SetActive(false);
        for (int i = 0; i < imagembotao.Length; i++) { imagembotao[i].color = corsalvar; textosave[i].text = bancodedados.carregardata(i); }
    }
    public void mudarparacarregar() {
        carregar = true; objetodosave.SetActive(true); menudosave = true; botoes.SetActive(false);
        for (int i = 0; i < imagembotao.Length; i++) { imagembotao[i].color = corcarregar; textosave[i].text = bancodedados.carregardata(i); }
    }
    public void fecharmenusave()
    {
        objetodosave.SetActive(false); menudosave = false; botoes.SetActive(true);
    }
    public void opcao1() { botaodialogo.SetActive(true); opcaorota.SetActive(false); opcao2rota.SetActive(false);    selected = valordarota[0]-1; mudanca = 0;nextDialog(); }
    public void opcao2() { botaodialogo.SetActive(true); opcaorota.SetActive(false); opcao2rota.SetActive(false);    selected = valordarota[1]-2; mudanca = 0; nextDialog(); }
    public void opcao3() { botaodialogo.SetActive(true); opcaorota.SetActive(false); opcao2rota.SetActive(false);    selected = valordarota[2]-2; mudanca = 0; nextDialog(); }























}
