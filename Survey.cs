using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using TMPro;

public class Survey : MonoBehaviour
{

    [SerializeField] TMP_InputField question1;
    [SerializeField] TMP_Dropdown question2;
    [SerializeField] TMP_Dropdown question3;
    [SerializeField] TMP_Dropdown question4;
    [SerializeField] TMP_InputField question5;
    [SerializeField] TMP_InputField question6;
    [SerializeField] TMP_InputField question7;
    [SerializeField] TMP_Dropdown question8;
    [SerializeField] TMP_InputField question9;
    [SerializeField] TMP_Dropdown question10;
    [SerializeField] TMP_Dropdown question11;
    [SerializeField] TMP_Dropdown question12;
    [SerializeField] TMP_Dropdown question13;
    [SerializeField] TMP_Dropdown question14;
    [SerializeField] TMP_Dropdown question15;
    [SerializeField] TMP_Dropdown question16;
    [SerializeField] TMP_InputField question17;
    [SerializeField] TMP_Dropdown question18;
    [SerializeField] TMP_InputField question19;
    [SerializeField] TMP_InputField question20;

    string URL = "https://docs.google.com/forms/u/0/d/e/1FAIpQLSfIXi5h0tQquki4JTe5NYZxY_NIH1BNGZxEC0r2kVRLWWqxlA/formResponse";

    public void Send()
    {
        StartCoroutine(Post());
    }

    IEnumerator Post()
    {
        WWWForm form = new WWWForm();
        // With what gender do you most identify?
        form.AddField("entry.1699927099", question1.text);
        // Do you identify as Hispanic/Latinx?
        form.AddField("entry.1595416596", question2.value);
        // Do you identify as a member of a black or brown community?
        form.AddField("entry.1844215027", question3.value);
        // What race/ethnicity or races/ethnicities do you identify with (List
        // all that apply)
        form.AddField("entry.1379504400", question7.text);
        // Would you say you live in an urban, peri-urban, or rural area?
        form.AddField("entry.561860576", question4.value);
        // What is your occupation?
        form.AddField("entry.24282849", question6.text);
        // What is your estimated annual household income?
        form.AddField("entry.421120807", question5.value);
        // Have you ever heard of the Trolley Problem before?
        form.AddField("entry.1405103451", question8.value);
        // If you have heard of the Trolley Problem, please briefly explain it
        form.AddField("entry.538232697", question9.text);
        // Do you generally trust other people?
        form.AddField("entry.550914768", question10.value);
        // Do you feel as though other people trust you?
        form.AddField("entry.1375757309", question11.value);
        // Do you generally trust yourself?
        form.AddField("entry.1391903084", question12.value);
        // Do you generally trust pedestrians in, on, or near the road when driving?
        form.AddField("entry.334831000", question13.value);
        // Do you feel as though pedestrians trust your driving when they're in, on, or near the road?
        form.AddField("entry.53593066", question14.value);
        // Have you heard of automated vehicles?
        form.AddField("entry.896636148", question15.value);
        // How would you rate your understanding of automated vehicles?
        form.AddField("entry.2067433351", question16.value);
        // If you have heard of automated vehicles, please explain your perception of what an automated vehicle is.
        form.AddField("entry.1254119119", question17.text);
        // How would you rate your trust in an automated vehicle on the road?
        form.AddField("entry.23924560", question18.value);
        
        // Do you think that automated vehicles should value the life of its passengers or people outside the vehicle more?
        form.AddField("entry.2072948661", question19.value);
        
        // If automated vehicles were to become available to you, would you use one?
        form.AddField("entry.1675933084", question20.value);


        UnityWebRequest www = UnityWebRequest.Post(URL, form);
        yield return www.SendWebRequest();
    }
}
