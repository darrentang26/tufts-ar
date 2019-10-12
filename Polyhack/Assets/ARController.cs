using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ARController : MonoBehaviour
{
    //public static bool halligan;
    //public static bool cannon;
    //public static bool sec;
    //public static bool tisch;

    public GameObject halligan_obj;
    public GameObject cannon_obj;
    public GameObject sec_obj;
    public GameObject tisch_obj;

    public Text the_review;
    public Text rating;

    private static int i;
    private int ave_rating;
    private static List<string> reviews = new List<string>();

    // Start is called before the first frame update
    void Start()
    {

    }

    public void NextPressed()
    {
        if (i == reviews.Count-1)
            i = 0;
        else
            i++;

        the_review.text = reviews[i];
    }


    public void BackPressed()
    {
        if (i == 0)
            i = reviews.Count - 1;
        else
            i--;

        the_review.text = reviews[i];
    }


    // Update is called once per frame
    void Update()
    {
        rating.text = ave_rating + "/5";
    }
}
