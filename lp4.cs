using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine. UI;
using TMPro;
public class lp4 : MonoBehaviour
{
        [SerializeField] public TextWriter textWriter;
    public TextMeshProUGUI output;
    // public int val;
    public static int s,f;
    [SerializeField] GameObject Emoji;
[SerializeField] GameObject Emoji1;

    // Update is called once per frame
    public void onclick1(int val)
    {
        // global s;
        if (val ==0)
        {
            
        }
        
        if (val ==1)
        {
            s=1;
    
        }
        
        if (val ==2)
        {
            s=2;
        }
        print("df"+s);

    }
    public void onclick2(int val)
    {
        
        
        if (val ==0)
        {
            
        }
        
        if (val ==1)
        {
            f=1;   
        }
        
        if (val==2)
        {
            f=2;
        }
        
        if (val ==3)
        {
            f=3;
        }

    }

    public void exec()
    {
    
        if (s==2 && f==3)
        {
            Text starttxt = GameObject.Find("Canvas/note1").GetComponent<Text>();
            textWriter.AddWriter(starttxt,"First 10 Natural Numbers : \n1  2  3  4  5  6  7  8  9  10",0.1f);
            Text result = GameObject.Find("Canvas/result1").GetComponent<Text>();
                            result.text = "You Won ! ! ! ";
                            Emoji1.SetActive(true);
        }
        if (s==2 && f==2)
        {
            Text starttxt = GameObject.Find("Canvas/note1").GetComponent<Text>();
            textWriter.AddWriter(starttxt,"First 10 Natural Numbers :\n1  2  3  4  5  6  7  8 ",0.1f);
                        Text result = GameObject.Find("Canvas/result1").GetComponent<Text>();
                            result.text = "You Lost ! ! ! ";
                            Emoji.SetActive(true);
        }
        if (s==1 && f==3)
        {
            Text starttxt = GameObject.Find("Canvas/note1").GetComponent<Text>();
            textWriter.AddWriter(starttxt,"First 10 Natural Numbers :\n0  1  2  3  4  5  6  7  8  9  10",0.1f);
                        Text result = GameObject.Find("Canvas/result1").GetComponent<Text>();
                            result.text = "You Lost ! ! ! ";
                            Emoji.SetActive(true);
        }
        if (s==1 && f==2)
        {
            Text starttxt = GameObject.Find("Canvas/note1").GetComponent<Text>();
            textWriter.AddWriter(starttxt,"First 10 Natural Numbers :\n0  1  2  3  4  5  6  7  8  ",0.1f);
                        Text result = GameObject.Find("Canvas/result1").GetComponent<Text>();
                            result.text = "You Lost ! ! ! ";
                            Emoji.SetActive(true);
        }
        if (s==1 && f==1)
        {
            Text starttxt = GameObject.Find("Canvas/note1").GetComponent<Text>();
            textWriter.AddWriter(starttxt,"First 10 Natural Numbers :\n0  1  2  3  4  5  6  7  8  9  ",0.1f);
                        Text result = GameObject.Find("Canvas/result1").GetComponent<Text>();
                            result.text = "You Lost ! ! ! ";
                            Emoji.SetActive(true);
        }
        if (s==2 && f==1)
        {
            Text starttxt = GameObject.Find("Canvas/note1").GetComponent<Text>();
            textWriter.AddWriter(starttxt,"First 10 Natural Numbers :\n1  2  3  4  5  6  7  8  9  ",0.1f);
                        Text result = GameObject.Find("Canvas/result1").GetComponent<Text>();
                            result.text = "You Lost ! ! ! ";
                            Emoji.SetActive(true);
        }
    }
}
