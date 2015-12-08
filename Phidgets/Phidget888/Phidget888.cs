// ****************************************************************************
// <copyright file="Phidget888.cs" company="IntuiLab">
// INTUILAB CONFIDENTIAL
//_____________________
// [2002] - [2015] IntuiLab SA
// All Rights Reserved.
// NOTICE: All information contained herein is, and remains
// the property of IntuiLab SA. The intellectual and technical
// concepts contained herein are proprietary to IntuiLab SA
// and may be covered by U.S. and other country Patents, patents
// in process, and are protected by trade secret or copyright law.
// Dissemination of this information or reproduction of this
// material is strictly forbidden unless prior written permission
// is obtained from IntuiLab SA.
// </copyright>
// ****************************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using Phidgets;
using Phidgets.Events;

namespace Phidget888
{
    internal class PhidgetController
    {
        #region Instance

        private static PhidgetController _instance = null;

        public static PhidgetController Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PhidgetController();
                }

                return _instance;
            }
        }

        #endregion

        #region Attributes

        //Declare an InterfaceKit object
        private InterfaceKit ifk;

        private int m_iWatchers = 0;

        #endregion

        #region Events

        public event InputChangeEventHandler InputChange;
        public event SensorChangeEventHandler SensorChange;

        #endregion

        #region Methods


        internal void Init()
        {
            ifk = new InterfaceKit();
            //Open the object for device connections
            ifk.open();

            //To listen to logical input (button pressed / released
            ifk.InputChange += new InputChangeEventHandler(ifk_InputChange);

            //NOT USED IN THIS PROJECT: analog input
            ifk.SensorChange += new SensorChangeEventHandler(ifk_SensorChange);
            
            //NOT USED IN THIS PROJECT: logical output
            //ifk.OutputChange += new OutputChangeEventHandler(ifk_OutputChange);                        
        }

        void ifk_SensorChange(object sender, SensorChangeEventArgs e)
        {
            if (SensorChange != null)
                SensorChange(this, e);
        }

       


        void ifk_InputChange(object sender, InputChangeEventArgs e)
        {
            if (InputChange != null)
                InputChange(this, e);
        }

        internal void AddInstanceWatcher()
        {
            m_iWatchers++;
            if (m_iWatchers == 1)
                Init();
        }

        internal void RemoveInstanceWatcher()
        {
            m_iWatchers--;
            if (m_iWatchers == 0)
            {
                if (ifk != null)
                {
                    ifk.InputChange -= ifk_InputChange;
                    ifk.close();

                }
            }
        }

        #endregion

        internal void SetOuput(int outputIndex_, bool bValue_)
        {
            if (0 <= outputIndex_ && outputIndex_ < ifk.outputs.Count)
            {
                ifk.outputs[outputIndex_] = bValue_;
            }
        }
    }

    public class Phidget888 : INotifyPropertyChanged, IDisposable
    {
        #region Internal properties

        private PhidgetController m_refController;

        private bool m_Intput_0 = false;
        private bool m_Intput_1 = false;
        private bool m_Intput_2 = false;
        private bool m_Intput_3 = false;
        private bool m_Intput_4 = false;
        private bool m_Intput_5 = false;
        private bool m_Intput_6 = false;
        private bool m_Intput_7 = false;

        private int m_iAnalogSensor_0 = 0, m_iAnalogSensor_1 = 0, m_iAnalogSensor_2 = 0, m_iAnalogSensor_3 = 0, m_iAnalogSensor_4 = 0, m_iAnalogSensor_5 = 0, m_iAnalogSensor_6 = 0, m_iAnalogSensor_7 = 0;

        #endregion

        #region Property

        public bool Input_0
        {
            get { return m_Intput_0; }
            set
            {
                if (m_Intput_0 != value)
                {
                    m_Intput_0 = value;
                    NotifyPropertyChanged("Input_0");
                }
            }
        }

        public bool Input_1
        {
            get { return m_Intput_1; }
            set
            {
                if (m_Intput_1 != value)
                {
                    m_Intput_1 = value;
                    NotifyPropertyChanged("Input_1");
                }
            }
        }

        public bool Input_2
        {
            get { return m_Intput_2; }
            set
            {
                if (m_Intput_2 != value)
                {
                    m_Intput_2 = value;
                    NotifyPropertyChanged("Input_2");
                }
            }
        }

        public bool Input_3
        {
            get { return m_Intput_3; }
            set
            {
                if (m_Intput_3 != value)
                {
                    m_Intput_3 = value;
                    NotifyPropertyChanged("Input_3");
                }
            }
        }

        public bool Input_4
        {
            get { return m_Intput_4; }
            set
            {
                if (m_Intput_4 != value)
                {
                    m_Intput_4 = value;
                    NotifyPropertyChanged("Input_4");
                }
            }
        }

        public bool Input_5
        {
            get { return m_Intput_5; }
            set
            {
                if (m_Intput_5 != value)
                {
                    m_Intput_5 = value;
                    NotifyPropertyChanged("Input_5");
                }
            }
        }

        public bool Input_6
        {
            get { return m_Intput_6; }
            set
            {
                if (m_Intput_6 != value)
                {
                    m_Intput_6 = value;
                    NotifyPropertyChanged("Input_6");
                }
            }
        }

        public bool Input_7
        {
            get { return m_Intput_7; }
            set
            {
                if (m_Intput_7 != value)
                {
                    m_Intput_7 = value;
                    NotifyPropertyChanged("Input_7");
                }
            }
        }



        public int AnalogSensor_0
        {
            get { return m_iAnalogSensor_0; }
            set
            {
                if (m_iAnalogSensor_0 != value)
                {
                    m_iAnalogSensor_0 = value;
                    NotifyPropertyChanged("AnalogSensor_0");
                }
            }
        }

        public int AnalogSensor_1
        {
            get { return m_iAnalogSensor_1; }
            set
            {
                if (m_iAnalogSensor_1 != value)
                {
                    m_iAnalogSensor_1 = value;
                    NotifyPropertyChanged("AnalogSensor_1");
                }
            }
        }

        public int AnalogSensor_2
        {
            get { return m_iAnalogSensor_2; }
            set
            {
                if (m_iAnalogSensor_2 != value)
                {
                    m_iAnalogSensor_2 = value;
                    NotifyPropertyChanged("AnalogSensor_2");
                }
            }
        }

        public int AnalogSensor_3
        {
            get { return m_iAnalogSensor_3; }
            set
            {
                if (m_iAnalogSensor_3 != value)
                {
                    m_iAnalogSensor_3 = value;
                    NotifyPropertyChanged("AnalogSensor_3");
                }
            }
        }

        public int AnalogSensor_4
        {
            get { return m_iAnalogSensor_4; }
            set
            {
                if (m_iAnalogSensor_4 != value)
                {
                    m_iAnalogSensor_4 = value;
                    NotifyPropertyChanged("AnalogSensor_4");
                }
            }
        }

        public int AnalogSensor_5
        {
            get { return m_iAnalogSensor_5; }
            set
            {
                if (m_iAnalogSensor_5 != value)
                {
                    m_iAnalogSensor_5 = value;
                    NotifyPropertyChanged("AnalogSensor_5");
                }
            }
        }

        public int AnalogSensor_6
        {
            get { return m_iAnalogSensor_6; }
            set
            {
                if (m_iAnalogSensor_6 != value)
                {
                    m_iAnalogSensor_6 = value;
                    NotifyPropertyChanged("AnalogSensor_6");
                }
            }
        }

        public int AnalogSensor_7
        {
            get { return m_iAnalogSensor_7; }
            set
            {
                if (m_iAnalogSensor_7 != value)
                {
                    m_iAnalogSensor_7 = value;
                    NotifyPropertyChanged("AnalogSensor_7");
                }
            }
        }



        #endregion

        #region Events

        public event EventHandler Button0Pressed;
        public event EventHandler Button0Released;

        public event EventHandler Button1Pressed;
        public event EventHandler Button1Released;

        public event EventHandler Button2Pressed;
        public event EventHandler Button2Released;

        public event EventHandler Button3Pressed;
        public event EventHandler Button3Released;

        public event EventHandler Button4Pressed;
        public event EventHandler Button4Released;

        public event EventHandler Button5Pressed;
        public event EventHandler Button5Released;

        public event EventHandler Button6Pressed;
        public event EventHandler Button6Released;

        public event EventHandler Button7Pressed;
        public event EventHandler Button7Released;

        #endregion

        #region Constructor
        
        public Phidget888()
        {

            m_refController = PhidgetController.Instance;
            m_refController.AddInstanceWatcher();

            m_refController.InputChange += new InputChangeEventHandler(m_refController_InputChange);
            m_refController.SensorChange += new SensorChangeEventHandler(m_refController_SensorChange);
        }

      

        public void Dispose()
        {
            if (m_refController != null)
            {
                m_refController.InputChange -= m_refController_InputChange;
                m_refController.RemoveInstanceWatcher();
            }
        }

        public void SetOutput(int outputIndex_, bool bValue_)
        {
            m_refController.SetOuput(outputIndex_, bValue_);
        }

        #endregion

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        #endregion

        #region callbacks

        void m_refController_InputChange(object sender, InputChangeEventArgs e)
        {
            switch (e.Index)
            {
                case 0:
                    Input_0 = e.Value;
                    if (Input_0 && Button0Pressed != null)
                        Button0Pressed(this, null);
                    if (!Input_0 && Button0Released != null)
                        Button0Released(this, null);
                    break;
                case 1:
                    Input_1 = e.Value;
                    if (Input_1 && Button1Pressed != null)
                        Button1Pressed(this, null);
                    if (!Input_1 && Button1Released != null)
                        Button1Released(this, null);
                    break;
                case 2:
                    Input_2 = e.Value;
                    if (Input_2 && Button2Pressed != null)
                        Button2Pressed(this, null);
                    if (!Input_2 && Button2Released != null)
                        Button2Released(this, null);
                    break;
                case 3:
                    Input_3 = e.Value;
                    if (Input_3 && Button3Pressed != null)
                        Button3Pressed(this, null);
                    if (!Input_3 && Button3Released != null)
                        Button3Released(this, null);
                    break;
                case 4:
                    Input_4 = e.Value;
                    if (Input_4 && Button4Pressed != null)
                        Button4Pressed(this, null);
                    if (!Input_4 && Button4Released != null)
                        Button4Released(this, null);
                    break;
                case 5:
                    Input_5 = e.Value;
                    if (Input_5 && Button5Pressed != null)
                        Button5Pressed(this, null);
                    if (!Input_5 && Button5Released != null)
                        Button5Released(this, null);
                    break;
                case 6:
                    Input_6 = e.Value;
                    if (Input_6 && Button6Pressed != null)
                        Button6Pressed(this, null);
                    if (!Input_6 && Button6Released != null)
                        Button6Released(this, null);
                    break;
                case 7:
                    Input_7 = e.Value;
                    if (Input_7 && Button7Pressed != null)
                        Button7Pressed(this, null);
                    if (!Input_7 && Button7Released != null)
                        Button7Released(this, null);
                    break;
                default:
                    break;
            }

        }

        void m_refController_SensorChange(object sender, SensorChangeEventArgs e)
        {
            switch (e.Index)
            {
                case 0:
                    AnalogSensor_0 = e.Value;
                    break;
                case 1:
                    AnalogSensor_1 = e.Value;
                    break;
                case 2:
                    AnalogSensor_2 = e.Value;
                    break;
                case 3:
                    AnalogSensor_3 = e.Value;
                    break;
                case 4:
                    AnalogSensor_4 = e.Value;
                    break;
                case 5:
                    AnalogSensor_5 = e.Value;
                    break;
                case 6:
                    AnalogSensor_6 = e.Value;
                    break;
                case 7:
                    AnalogSensor_7 = e.Value;
                    break;
                default:
                    break;
            }
        }

        #endregion
     
    }
}
