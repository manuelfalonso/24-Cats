using UnityEngine;
using UnityEngine.Advertisements;

public class AdDisplay : MonoBehaviour
{
    public string myGameIdAndroid = "4291989";
    public string myGameIdIOS = "4291988";
    public string myVideoPlacement = "Rewarded_Android";
    public bool adStarted;

    private bool testMode = true;

    private void Start()
    {
#if UNITY_IOS
        Advertisement.Initializa(myGameIdIOS, testMode);
#else
        Advertisement.Initialize(myGameIdAndroid, testMode);
#endif        
    }

    private void Update()
    {
        if (Advertisement.isInitialized && Advertisement.IsReady(myVideoPlacement) && !adStarted)
        {
            Advertisement.Show(myVideoPlacement);
            adStarted = true;
        }
    }


}
