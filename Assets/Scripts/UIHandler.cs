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
        // according to Dr. Kessler 
        procedureDescriptions = new string[] {
            "Ensure machine is plugged in.",
            "Turn on machine and select proper setting (vascular).",
            "Adjust 'gain' and 'depth' knobs to bring relevant anatomy into optimal field of view.",
            "Visualize internal jugular (and other neck anatomy) on both right and left side to help select procedural site.",
            "(Sterilize actions. e.g. hand hygiene.)",
            "(Additional actions. e.g. preparing the kit, draping the patient, ensuring they are on a monitor.)",
            "Apply sterile sheath to ultrasound probe.",
            "Visualize region of interest in cross-section and long-axis.",
            "(Direct guidance method - TBD)",
            "(Intermediary steps related solely to procedure. e.g. vsiualize blood flash, enlarge area with scalpel nick.)",
            "Insert catheter over wire and confirm wire is removed.",
            "Confirm flushes with ultrasound",
            "(Secondary confirmations. e.g. manometry.)"
        };
        nStep = procedureDescriptions.Length;
    }
}
