using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class move : MonoBehaviour
{
    [SerializeField] AudioSource music ;
    [SerializeField] GameObject Square11;
        [SerializeField] GameObject start1;
        [SerializeField] GameObject info;

    [SerializeField] GameObject fin1;
    [SerializeField] GameObject square;
    // public int loc;
    // public Sprite newsprite;
    [SerializeField] public TextWriter textWriter;
    public void musicon()
    {
        music.Play();
        // print("hii");
    }
    public void musicoff()
    {
        music.Stop();
    }
    public void movecart()
    {
        // for (int i =0 ; i<=2 ;i++)
        // {
       
        StartCoroutine(go());
      
        // Text code = GameObject.Find("maingame/Canvas/ans/code1").GetComponent<Text>();
        // code.text = "for i in range ( 0 , 4 ) :\n\t\t Iteration 1 \n\t\t//Cart moved from Shop 0 to Shop 1";
        
    }
    public void cartbck()
    {
        
        transform.position = new Vector2 ((float)-20.312 , (float)-185.466);
        Text code = GameObject.Find("maingame/Canvas/code1").GetComponent<Text>();
        code.text = "";
        Text code1 = GameObject.Find("maingame/Canvas/code2").GetComponent<Text>();
        code.text = "";
        Text code2 = GameObject.Find("maingame/Canvas/code3").GetComponent<Text>();
        code.text = "";
        Text result = GameObject.Find("maingame/Canvas/result1").GetComponent<Text>();
        result.text ="";
        Text index4 = GameObject.Find("maingame/Canvas/ans/pos1").GetComponent<Text>();
        index4.text = "";
        Text index5 = GameObject.Find("maingame/Canvas/ans/pos2").GetComponent<Text>();
        index5.text = "";
        
    }

    public void cartbck1()
    {
        // SceneManager.LoadScene(1);
        info.SetActive(false);
        square.SetActive(true);
        start1.SetActive(false);
        Text code2 = GameObject.Find("maingame/Canvas/ans/code1").GetComponent<Text>();
        code2.text="";
        Text code5= GameObject.Find("maingame/Canvas/ans/code2").GetComponent<Text>();
        code5.text="";
         Text code4= GameObject.Find("maingame/Canvas/ans/code3").GetComponent<Text>();
        code4.text="";
         Text code7= GameObject.Find("maingame/Canvas/ans/note1").GetComponent<Text>();
        code7.text="";
        transform.position = new Vector2 ((float)-20.312 , (float)-185.466);
        Text code = GameObject.Find("maingame/Canvas/ans/code1").GetComponent<Text>();
        code.text = "";
        // print("hii");
        Text result = GameObject.Find("maingame/Canvas/ans/note1").GetComponent<Text>();
        result.text ="";
        for (int i =0 ; i<=4 ;i++)
        {
            Text index = GameObject.Find("maingame/Canvas/i"+(i)+"").GetComponent<Text>();
            index.text = "";
        }
    }

    public void start()
    {
        print("hi");
    }
    
    
    public IEnumerator go()
    {
               
        // Text index1 = GameObject.Find("maingame/Canvas/i0").GetComponent<Text>();
        // index1.text = " i = 0";
        Text index3 = GameObject.Find("maingame/Canvas/ans/pos1").GetComponent<Text>();
        index3.text = "Home";
        // Square11.SetActive(true);
        
        for (int i =0 ; i<4 ;i++)
        {
            
            
            
            
            
            if (i<3)
            {
                
                transform.position = new Vector2 ( transform.position.x+(float)1.4 , (float)-185.466);
                if (i == 0)
                {
                    Text code = GameObject.Find("maingame/Canvas/ans/code1").GetComponent<Text>();
                    textWriter.AddWriter(code,"for i in range ( 0 , 4 ) :\n\t\t Iteration 1 \n\t\t//Cart moved from Home to Shop 1",0.025f);
                    Text index = GameObject.Find("maingame/Canvas/i"+(i)+"").GetComponent<Text>();
                    index.text = " i = "+(i)+"";
                    start1.SetActive(true);
                    yield return new WaitForSeconds(3f);

                }
                if (i == 1)
                {
                    Text code1 = GameObject.Find("maingame/Canvas/ans/code2").GetComponent<Text>();
                    textWriter.AddWriter(code1,"\t\t Iteration 2 \n\t\t//Cart moved from Shop 1 to Shop 2",0.05f);
                    Text index = GameObject.Find("maingame/Canvas/i"+(i)+"").GetComponent<Text>();
                    index.text = " i = "+(i)+"";
                    yield return new WaitForSeconds(3f);

                }
                if (i == 2)
                {
                    Text code1 = GameObject.Find("maingame/Canvas/ans/code3").GetComponent<Text>();
                    textWriter.AddWriter(code1,"\t\t Iteration 3 \n\t\t//Cart moved from Shop 2 to Shop 3",0.05f);
                    Text index = GameObject.Find("maingame/Canvas/i"+(i)+"").GetComponent<Text>();
                    index.text = " i = "+(i)+"";
                    print(transform.position.x);
                    fin1.SetActive(true);
                    // square.SetActive(false);
                    yield return new WaitForSeconds(3f);
                }
                
                
                
            }
            Text index1 = GameObject.Find("maingame/Canvas/i"+(i)+"").GetComponent<Text>();
            index1.text = " i = "+(i)+"";
            
            
        }
        
        Text index2 = GameObject.Find("maingame/Canvas/ans/pos2").GetComponent<Text>();
        index2.text = " Shop 3 ";
        yield return new WaitForSeconds(1.5f);
        Text result = GameObject.Find("maingame/Canvas/ans/note1").GetComponent<Text>();
        textWriter.AddWriter(result,"The range() function defaults to 0 as a starting value,however it is possible to specify the starting value.\nRange function does not include last value.",0.05f);
                            square.SetActive(false);

        
    }
   
}





