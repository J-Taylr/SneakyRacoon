using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup : MonoBehaviour
{
    public bool eating = false;
    public GameObject PopUp;
    public Text Lines;
    

    public string[] RacoonQoutes =
        
    {
        "What an exquisite delicacy!",
        "Mmmmm, I haven’t been able to enjoy something so delicious in months.",
        "I say, this food is absolutely superb.",
        "I truly am feasting like royalty tonight",
        "Mayhaps I shall return here one day, their selection of foodstuffs is simply divine.",
        "My stomach is jumping with joy at this mouth-watering morsel.",
        "Such a scrumptious meal!",
        "This food is simply delectable.",
    };
    // Start is called before the first frame update
    void Start()
    {
        PopUp.SetActive(true);
        Lines.text = " I can already smell the heavenly feast awaiting me inside this abode. If I am to enjoy such luxuries I must be careful not to alert the noble residents of this house.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartChat()
    {
        print("TheFunctionWorked");
        if (eating == false)
        {
            StartCoroutine("Chat");
        }
    }
    IEnumerator Chat()
    {
        eating = true;
        PopUp.SetActive(true);
        Lines.text = RacoonQoutes[Random.Range(0, RacoonQoutes.Length)];
        yield return new WaitForSeconds(5);
        Lines.text = "";
        eating = false;
        PopUp.SetActive(false);
    }


    
}
