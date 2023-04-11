using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.UI;


public class lp1 : MonoBehaviour
{
    public int startloc ;   
    public int finalloc ;
    public int starthome;
    [SerializeField] GameObject fin;
    [SerializeField] GameObject fin1;
    [SerializeField] GameObject fin2;
    [SerializeField] GameObject fin3;
    [SerializeField] GameObject fin4;
    [SerializeField] GameObject Square5;
    [SerializeField] GameObject Square1;
    [SerializeField] GameObject Square2;
    [SerializeField] GameObject Square3;
    [SerializeField] GameObject Square4;
    [SerializeField] GameObject intro;
    [SerializeField] GameObject maingame1;

    [SerializeField] GameObject Square;
    [SerializeField] GameObject Emoji;

    [SerializeField] GameObject Emoji1;


    

    [SerializeField] public TextWriter textWriter; 
    public void replay()
    {
            intro.SetActive(false);
            maingame1.SetActive(true);
    }
    public void left()
    {
        if (transform.position.x > (float)-20.312 )
        {
            transform.position = new Vector2 ( transform.position.x-(float)1.4 , (float)-185.466);
        }
    }

    public void right()
    {
        if (transform.position.x < (float)-14.713 )
        {
            transform.position = new Vector2 ( transform.position.x+(float)1.4, (float)-185.466);
        }
    }

    public void begin()
    {
      

        if (Mathf.Approximately(transform.position.x, -20.312f) )
        {
            startloc=0;
            starthome=1;
            Text starttxt = GameObject.Find("maingame/Canvas/pos1").GetComponent<Text>();
            starttxt.text = "HOME";
            Square1.SetActive(true);
        }
        else if (Mathf.Approximately(transform.position.x, -18.912f))
        {
            starthome=0;
            startloc=1;
            Text starttxt = GameObject.Find("maingame/Canvas/pos1").GetComponent<Text>();
            starttxt.text = "SHOP 1";
            Square2.SetActive(true);
        }
        else if (Mathf.Approximately(transform.position.x, -17.512f))
        {
            startloc=2;
            starthome=0;
            Text starttxt = GameObject.Find("maingame/Canvas/pos1").GetComponent<Text>();
            starttxt.text = "SHOP 2";
            Square3.SetActive(true);
        }
        else if (Mathf.Approximately(transform.position.x,-16.112f))
        {
            starthome=0;
            startloc=3;    
            Text starttxt = GameObject.Find("maingame/Canvas/pos1").GetComponent<Text>();
            starttxt.text = "SHOP 3";   
            Square4.SetActive(true);
             }
        else if (Mathf.Approximately(transform.position.x,-14.712f))
        {
            startloc=4;
            starthome=0;
            Text starttxt = GameObject.Find("maingame/Canvas/pos1").GetComponent<Text>();
            starttxt.text = "SHOP 4";
            Square5.SetActive(true);
        }
        

        
        
    }
    public void cartbck1()
    {
        
        transform.position = new Vector2 ((float)-20.312 , (float)-185.466);
        Text result1 = GameObject.Find("maingame/Canvas/result1").GetComponent<Text>();
        result1.text = "";
        Text code3 = GameObject.Find("maingame/Canvas/code1").GetComponent<Text>();
                   
        textWriter.AddWriter(code3,"",0f);
        StartCoroutine(go1());
        
        
    }
    public void end()
    {
        if (Mathf.Approximately(transform.position.x, -20.312f) )
        {
            finalloc=1;
            Text finaltxt = GameObject.Find("maingame/Canvas/pos2").GetComponent<Text>();
            finaltxt.text = "HOME";
            fin.SetActive(true); 
            Square.SetActive(false) ;          
        }
        else if (Mathf.Approximately(transform.position.x, -18.912f))
        {
            finalloc=2;
            Text finaltxt = GameObject.Find("maingame/Canvas/pos2").GetComponent<Text>();
            finaltxt.text = "SHOP 1";
            fin1.SetActive(true);
            Square.SetActive(false)     ;      

            // this.gameObject.GetComponent<SpriteRenderer>().sprite=fin;
        }
        else if (Mathf.Approximately(transform.position.x, -17.512f))
        {
            finalloc=3;
            Text finaltxt = GameObject.Find("maingame/Canvas/pos2").GetComponent<Text>();
            finaltxt.text = "SHOP 2";
            fin2.SetActive(true);
            Square.SetActive(false)         ;  
            // this.gameObject.GetComponent<SpriteRenderer>().sprite=fin;
        }
        else if (Mathf.Approximately(transform.position.x,-16.112f))
        {
            finalloc=4;
            Text finaltxt = GameObject.Find("maingame/Canvas/pos2").GetComponent<Text>();
            finaltxt.text = "SHOP 3";
            fin3.SetActive(true);
            Square.SetActive(false)     ;      
            // this.gameObject.GetComponent<SpriteRenderer>().sprite=fin;
        }
        else if (Mathf.Approximately(transform.position.x,-14.712f))
        {
            finalloc=5;
            Text finaltxt = GameObject.Find("maingame/Canvas/pos2").GetComponent<Text>();
            finaltxt.text = "SHOP 4";
            Square.SetActive(false)       ;    
            fin4.SetActive(true);
            // this.gameObject.GetComponent<SpriteRenderer>().sprite=fin;
        }
        
    }
    public void run()
    {
                    Square.SetActive(true);           

       if (startloc == 9 || finalloc == 9)
       {
            
       }
       else
       {
            Emoji.SetActive(true);
            // StartCoroutine(go1());
            if (startloc == finalloc-1)
            {
                Text index = GameObject.Find("maingame/Canvas/i"+(startloc)+"").GetComponent<Text>();
                index.text = " i = 0";
            }
            if (startloc == finalloc-2)
            {
                Text index = GameObject.Find("maingame/Canvas/i"+(startloc)+"").GetComponent<Text>();
                index.text = " i = 0";
            }

        
            // {
                // int p=finalloc - startloc;
                // for (int x = 0 ; x<p ;x++)
                // {
                //     print("start"+l);
                //     print(x);
                //     int z=l+x;
                //     Text index = GameObject.Find("maingame/Canvas/i"+z+"").GetComponent<Text>();
                //     textWriter.AddWriter(index," i = "+x+"",0f);
                //     yield return new WaitForSeconds(1.5f);

            //     }
            // }
                if (startloc==0)
                {
                    transform.position = new Vector2 ((float)(-20.312 -1.4), (float)-185.466);
                }
                else if (startloc==1)
                {
                    transform.position = new Vector2 ((float)(-18.912 -1.4) , (float)-185.466);
                }
                else if (startloc==2)
                {
                    transform.position = new Vector2 ((float)(-17.512 -1.4) , (float)-185.466);
                }
                else if (startloc==3)
                {
                    transform.position = new Vector2 ((float)(-16.112 -1.4) , (float)-185.466);
                }
                else if (startloc==4)
                {
                    transform.position = new Vector2 ((float)(-14.712 -1.4) , (float)-185.466);
                }
                StartCoroutine(go());
           
           
       }
    }
    public IEnumerator go()
    {
        if (startloc==0 && finalloc==4)
                        {
                            Text result = GameObject.Find("maingame/Canvas/result1").GetComponent<Text>();
                            result.text = "    		You Won  ! ! ! ";
            
                                                Emoji1.SetActive(true);           

                            
                        }
                        else{
                            Text result = GameObject.Find("maingame/Canvas/result1").GetComponent<Text>();
                            result.text = "    		You Lost  ! ! ! ";
                            Emoji.SetActive(true);           



                        }
        int p=finalloc - startloc;
        int l=startloc;
        for (int x = 0 ; x<p ;x++)
                {
                    print("start"+l);
                    print(x);
                    int z=l+x;
                    
                    transform.position = new Vector2 ( transform.position.x+(float)1.4 , (float)-185.466);
                    yield return new WaitForSeconds(1f);
                    Text code = GameObject.Find("maingame/Canvas/code1").GetComponent<Text>();
                    if (x == 0)
                    {
                        
                        textWriter.AddWriter(code,"for i in range ( "+startloc+" , "+finalloc+") :",0.05f);
                        yield return new WaitForSeconds(1.5f);
                    
                    }
                    if (starthome==1){
                        if(x==1)
                        {
                            Text code1 = GameObject.Find("maingame/Canvas/code2").GetComponent<Text>();
                        textWriter.AddWriter(code1,"\t\t Iteration 1 \n\t\t//Cart moved from HOME to Shop "+(z)+"",0.05f);
    yield return new WaitForSeconds(1.7f);
                        }
                        if(x==2)
                        {
                            Text code1 = GameObject.Find("maingame/Canvas/code3").GetComponent<Text>();
                        textWriter.AddWriter(code1,"\t\t Iteration 2 \n\t\t//Cart moved from Shop"+(z-1)+" to Shop "+(z)+"",0.05f);
    yield return new WaitForSeconds(1.7f);
                        }
                        if(x==3)
                        {
                            Text code1 = GameObject.Find("maingame/Canvas/code4").GetComponent<Text>();
                        textWriter.AddWriter(code1,"\t\t Iteration 3 \n\t\t//Cart moved from Shop"+(z-1)+" to Shop "+(z)+"",0.05f);
    yield return new WaitForSeconds(1.7f);
                        }
                        if(x==4)
                        {
                            Text code1 = GameObject.Find("maingame/Canvas/code5").GetComponent<Text>();
                        textWriter.AddWriter(code1,"\t\t Iteration 4 \n\t\t//Cart moved from Shop"+(z-1)+" to Shop "+(z)+"",0.05f);
    yield return new WaitForSeconds(1.7f);
                        }
                    }
                    else {
                            if(x==1)
                        {
                            Text code1 = GameObject.Find("maingame/Canvas/code2").GetComponent<Text>();
                        textWriter.AddWriter(code1,"\t\t Iteration 1 \n\t\t//Cart moved from Shop"+(z-1)+" to Shop "+(z)+"",0.05f);
    yield return new WaitForSeconds(1.7f);
                        }
                        if(x==2)
                        {
                            Text code1 = GameObject.Find("maingame/Canvas/code3").GetComponent<Text>();
                        textWriter.AddWriter(code1,"\t\t Iteration 2 \n\t\t//Cart moved from Shop"+(z-1)+" to Shop "+(z)+"",0.05f);
    yield return new WaitForSeconds(1.7f);
                        }
                        if(x==3)
                        {
                            Text code1 = GameObject.Find("maingame/Canvas/code4").GetComponent<Text>();
                        textWriter.AddWriter(code1,"\t\t Iteration 3 \n\t\t//Cart moved from Shop"+(z-1)+" to Shop "+(z)+"",0.05f);
    yield return new WaitForSeconds(1.7f);
                        }
                        if(x==4)
                        {
                            Text code1 = GameObject.Find("maingame/Canvas/code5").GetComponent<Text>();
                        textWriter.AddWriter(code1,"\t\t Iteration 4 \n\t\t//Cart moved from Shop"+(z-1)+" to Shop "+(z)+"",0.05f);
    yield return new WaitForSeconds(1.7f);
                        }
                    }
                    Text index = GameObject.Find("maingame/Canvas/i"+z+"").GetComponent<Text>();
                    textWriter.AddWriter(index," i = "+x+"",0f);
                    yield return new WaitForSeconds(0.025f);
                                 

    }
    Square.SetActive(false);
    }
    public IEnumerator go1()
     {
        int p=finalloc - startloc;
        int l=startloc;
        for (int x = 0 ; x<p ;x++)
                {
                    print("start"+l);
                    print(x);
                    int z=l+x;
                    Text index = GameObject.Find("maingame/Canvas/i"+z+"").GetComponent<Text>();
                    textWriter.AddWriter(index," ",0f);
                    yield return new WaitForSeconds(0.1f);
    }
    }
   
  
}


