using System;
using UnityEngine;
<<<<<<< Updated upstream
using UnityEngine.UI;

namespace UnityStandardAssets.Utility
{
    [RequireComponent(typeof (Text))]
=======

namespace UnityStandardAssets.Utility
{
    [RequireComponent(typeof (GUIText))]
>>>>>>> Stashed changes
    public class FPSCounter : MonoBehaviour
    {
        const float fpsMeasurePeriod = 0.5f;
        private int m_FpsAccumulator = 0;
        private float m_FpsNextPeriod = 0;
        private int m_CurrentFps;
        const string display = "{0} FPS";
<<<<<<< Updated upstream
        private Text m_Text;
=======
        private GUIText m_GuiText;
>>>>>>> Stashed changes


        private void Start()
        {
            m_FpsNextPeriod = Time.realtimeSinceStartup + fpsMeasurePeriod;
<<<<<<< Updated upstream
            m_Text = GetComponent<Text>();
=======
            m_GuiText = GetComponent<GUIText>();
>>>>>>> Stashed changes
        }


        private void Update()
        {
            // measure average frames per second
            m_FpsAccumulator++;
            if (Time.realtimeSinceStartup > m_FpsNextPeriod)
            {
                m_CurrentFps = (int) (m_FpsAccumulator/fpsMeasurePeriod);
                m_FpsAccumulator = 0;
                m_FpsNextPeriod += fpsMeasurePeriod;
<<<<<<< Updated upstream
                m_Text.text = string.Format(display, m_CurrentFps);
=======
                m_GuiText.text = string.Format(display, m_CurrentFps);
>>>>>>> Stashed changes
            }
        }
    }
}
