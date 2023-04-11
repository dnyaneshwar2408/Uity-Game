using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.UI;

public class lp2 : MonoBehaviour
{
    public Sprite Setimg;

[SerializeField] GameObject Emoji;
[SerializeField] GameObject Emoji1;
[SerializeField] GameObject p1;
[SerializeField] GameObject p2;
[SerializeField] GameObject p3;
[SerializeField] GameObject p4;
[SerializeField] GameObject Square;
    public void option1()
    {
                            p4.SetActive(false);

                    p3.SetActive(false);
                    Square.SetActive(true);

        // this.gameObject.GetComponent<SpriteRenderer>().sprite = Setimg;
        transform.position = new Vector2 ((float)-15.57 , (float)-186.17);

        StartCoroutine(go1());
    }


    public IEnumerator go1()
    {
        if (transform.position.x < (float)-12.77)
        {
            Text result = GameObject.Find("maingame/Canvas/result1").GetComponent<Text>();
                            result.text = "    		You Lost  ! ! ! ";
                            Emoji.SetActive(true);
                            p3.SetActive(true);
            for (int i =0 ; i<2 ;i++)
            {
                
                yield return new WaitForSeconds(1);
                transform.position = new Vector2 ( transform.position.x+(float)1.4 , (float)-186.17);
                
            }
                            yield return new WaitForSeconds(1);

            Square.SetActive(false);

        }
    }
    public void option2()
    {
                            p3.SetActive(false);
                                                p4.SetActive(false);


                            Square.SetActive(true);

        // transform.position.x = (float)-14.17;
        transform.position = new Vector2 ((float)-14.17 , (float)-186.17);
        // this.gameObject.GetComponent<SpriteRenderer>().sprite = Setimg;
        StartCoroutine(go2());
    }


    public IEnumerator go2()
    {
        Text result = GameObject.Find("maingame/Canvas/result1").GetComponent<Text>();
                            result.text = "    		You Won  ! ! ! ";
                            Emoji1.SetActive(true);
                                    p4.SetActive(true);

        if (transform.position.x < (float)-11.37)
        {
            for (int i =0 ; i<2 ;i++)
            {
                
                yield return new WaitForSeconds(1);
                transform.position = new Vector2 ( transform.position.x+(float)1.4 , (float)-186.17);
                
            }
                            yield return new WaitForSeconds(1);

                        Square.SetActive(false);

        }
    }
    public void option3()
    {
                            p3.SetActive(false);
                    p4.SetActive(false);

                            Square.SetActive(true);

        // transform.position.x = (float)12.77;
        transform.position = new Vector2 ( (float)-12.77 , (float)-186.17);
        // this.gameObject.GetComponent<SpriteRenderer>().sprite = Setimg;
        StartCoroutine(go3());
    }


    public IEnumerator go3()
    {
        Text result = GameObject.Find("maingame/Canvas/result1").GetComponent<Text>();
                            result.text = "    		You Lost  ! ! ! ";
                            Emoji.SetActive(true);
                            p4.SetActive(true);
        if (transform.position.x < (float)-11.37)
        {
            for (int i =0 ; i<1 ;i++)
            {
                
                yield return new WaitForSeconds(1);
                transform.position = new Vector2 (transform.position.x + (float)1.4 , (float)-186.17);
                
            }
                            yield return new WaitForSeconds(1);

                        Square.SetActive(false);

        }
    }
    public void option4()
    {
                            p3.SetActive(false);
                    p4.SetActive(false);

                            Square.SetActive(true);

        // transform.position.x = (float)-14.17;
        transform.position = new Vector2 ( (float)-14.17 , (float)-186.17);

        // this.gameObject.GetComponent<SpriteRenderer>().sprite = Setimg;
        StartCoroutine(go4());
    }


    public IEnumerator go4()
    {
        Text result = GameObject.Find("maingame/Canvas/result1").GetComponent<Text>();
                            result.text = "    		You Lost  ! ! ! ";
                            Emoji.SetActive(true);
                                                        p3.SetActive(true);

        if (transform.position.x < (float)-12.77)
        {
            for (int i =0 ; i<1 ;i++)
            {
                
                yield return new WaitForSeconds(1);
                transform.position = new Vector2 ( transform.position.x+(float)1.4 , (float)-186.17);
                
                
            }
                            yield return new WaitForSeconds(1);

                        Square.SetActive(false);

        }
    }
}
