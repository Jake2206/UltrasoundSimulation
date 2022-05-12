using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIHandler : MonoBehaviour
{
    // Operating Instruction Panel
    public GameObject operatingInstrPanel;
    bool operatingInstrToggle;

    // Procedure Instruction Panel
    public GameObject procedureInstrPanel;
    public TextMeshProUGUI procedureStepIndicatorText;
    public TextMeshProUGUI procedureContent;
    public Button nextStepButton;
    public Button prevStepButton;
    string[] procedureDescriptions;
    int nStep;
    int currentStep;

    // Status Panel
    public TextMeshProUGUI statusContent;

    void Start()
    {
        // Operating Instruction Panel
        operatingInstrToggle = false;
        operatingInstrPanel.SetActive(false);

        // Procedure Instruction Panel
        ImportProcedureDescriptions();
        SetStep(0);
    }

    public void ToggleOperatingInstrPanel()
    {
        operatingInstrToggle = !operatingInstrToggle;
        operatingInstrPanel.SetActive(operatingInstrToggle);
    }

    public void NextStep()
    {
        if (currentStep + 1 < nStep)
        {
            SetStep(currentStep + 1);
        }
    }

    public void PrevStep()
    {
        if (currentStep - 1 >= 0)
        {
            SetStep(currentStep - 1);
        }
    }

    void SetStep(int step)
    {
        currentStep = step;

        UpdateProcedureInstr();

        prevStepButton.GetComponent<Image>().color = (step == 0) ? Color.grey : Color.white;
        nextStepButton.GetComponent<Image>().color = (step == nStep - 1) ? Color.grey : Color.white;
    }

    void UpdateProcedureInstr()
    {
        procedureStepIndicatorText.text = String.Format("[Step {0} / {1}]", currentStep+1, nStep); // in real world we count from 1
        procedureContent.text = procedureDescriptions[currentStep];
    }

    void ImportProcedureDescriptions()
    {
        if (transform.gameObject.tag == "procedure instructions")
        {
            // according to Dr. Kessler 
            procedureDescriptions = new string[] {
            "Place the ultrasound probe on the human body.",
            "Slowly move the probe and watch the ultrasound image carefully.",
            "Visualize internal jugular on both right and left side to help select procedural site.",
            "Hold syringe in hand and insert.",
            "You have now finished the procedure.",
            };
        }else if (transform.gameObject.tag == "controller instructions")
        {
            procedureDescriptions = new string[] {
            "Welcome to Ultrasound Training Simulation. \nTo press buttons use your virual hand to touch them or find the ray coming out of your hand aim it and pinch your thumb and pointer finger. \nPress > to move on to next step, press < to go to the previous step.",
            "To travel you can physically walk around or you can teleport. \nTo teleport point your left palm upward, make a backward L with your thumb and pointer finger, aim the arced ray and pull your pointer finger towards your body.",
            "To grab the probe, syringe, or ultrasound screen you can simply reach out and grab them with your virtual hand.",
            "To switch the probe type between linear and curvilinear press the 'Switch Probe' button on the ultrasound screen.",
            "To adjust the height of the patient you can use the pointer and pinch technique to move the patient up and down.",
            "You can now move on to the ultrasound training by pressing the blue help button above the ultrasound screen. \nUse the help button to return to this tutorial.",
        };
        }
        nStep = procedureDescriptions.Length;
    }
}

// "(Sterilize actions. e.g. hand hygiene.)",
//"(Additional actions. e.g. preparing the kit, draping the patient, ensuring they are on a monitor.)",
//            "Apply sterile sheath to ultrasound probe.",
//            "Visualize region of interest in cross-section and long-axis.",
//            "(Direct guidance method - TBD)",
//            "(Intermediary steps related solely to procedure. e.g. vsiualize blood flash, enlarge area with scalpel nick.)",
//            "Insert catheter over wire and confirm wire is removed.",
//            "Confirm flushes with ultrasound",
//            "(Secondary confirmations. e.g. manometry.)"
