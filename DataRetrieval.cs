using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

[System.Serializable]
public class placeInfo
{
    public string [] reviews;
    public int avgRating;
}
[System.Serializable]
public class DataRetrieval : MonoBehaviour
{
    public string halliganURL = "afternoon-garden-34580.herokuapp.com/retrieve?place=halligan";
    public string tischURL = "afternoon-garden-34580.herokuapp.com/retrieve?place=tisch";
    public string SECURL = "afternoon-garden-34580.herokuapp.com/retrieve?place=SEC";
    public string cannonURL = "afternoon-garden-34580.herokuapp.com/retrieve?place=cannon";
    public placeInfo Halligan, Tisch, Cannon, SEC;

    void Start()
    {
        print("test");
        StartCoroutine(GetHalligan());
        StartCoroutine(GetSEC());
        StartCoroutine(GetTisch());
        StartCoroutine(GetCannon());
    }


    private IEnumerator GetHalligan()
    {
        using (UnityWebRequest uwr = UnityWebRequest.Get(halliganURL))
        {
            yield return uwr.SendWebRequest();
            if (uwr.isNetworkError || uwr.isHttpError)
            {
                Debug.Log(uwr.error);
            }
            else
            {
                var data = uwr.downloadHandler.text;
                Debug.Log(data);
                Halligan  = JsonUtility.FromJson<placeInfo>(data);
                Debug.Log("Success!");
            }
        }
    }
    private IEnumerator GetSEC()
    {
        using (UnityWebRequest uwr = UnityWebRequest.Get(SECURL))
        {
            yield return uwr.SendWebRequest();
            if (uwr.isNetworkError || uwr.isHttpError)
            {
                Debug.Log(uwr.error);
            }
            else
            {
                var data = uwr.downloadHandler.text;
                Debug.Log(data);
                SEC = JsonUtility.FromJson<placeInfo>(data);
                Debug.Log("Success!");
            }
        }
    }
    private IEnumerator GetTisch()
    {
        using (UnityWebRequest uwr = UnityWebRequest.Get(tischURL))
        {
            yield return uwr.SendWebRequest();
            if (uwr.isNetworkError || uwr.isHttpError)
            {
                Debug.Log(uwr.error);
            }
            else
            {
                var data = uwr.downloadHandler.text;
                Debug.Log(data);
                Tisch = JsonUtility.FromJson<placeInfo>(data);
                Debug.Log("Success!");
            }
        }
    }
    private IEnumerator GetCannon()
    {
        using (UnityWebRequest uwr = UnityWebRequest.Get(cannonURL))
        {
            yield return uwr.SendWebRequest();
            if (uwr.isNetworkError || uwr.isHttpError)
            {
                Debug.Log(uwr.error);
            }
            else
            {
                var data = uwr.downloadHandler.text;
                Debug.Log(data);
                Cannon = JsonUtility.FromJson<placeInfo>(data);
                Debug.Log("Success!");
            }
        }
    }

}
