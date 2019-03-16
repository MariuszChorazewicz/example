using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGD
{
    class Program
    {
        class TV
        {private
            int _diagonal;
            string _resolution;
            int _weight;
            int _warranty;
            int _volume;
            int _brighnest;
            int _quantityHDMIPort;
            int _quantityUSBPort;
            string _marka;
            string _model;
            bool _smartTV;
            bool _isTvConect;
            bool _isTvOn;
            bool _isTvOnline;

        public TV()
            {
                _diagonal = 32;
                _resolution = "1920 x 1080";
                _weight = 15;
                _warranty = 24;
                _volume = 15;
                _brighnest = 20;
                _quantityHDMIPort = 4;
                _quantityUSBPort = 3;
                _marka = "Samsung";
                _model = "UE32N5002";
                _smartTV = true;
                _isTvConect = false;
                _isTvOn = false;
                _isTvOnline = false;

            }
        public TV(int diagonal,string model,bool smartTV)
            {
                _diagonal = diagonal;
                _resolution = "1920 x 1080";
                _weight = 15;
                _warranty = 24;
                _volume = 15;
                _brighnest = 20;
                _quantityHDMIPort = 4;
                _quantityUSBPort = 3;
                _marka = "Samsung";
                _model = model;
                _smartTV = smartTV;
                _isTvConect = false;
                _isTvOn = false;
                _isTvOnline = false;
            }
        public TV(TV TVCopy)
            {
                _diagonal = TVCopy._diagonal;
                _resolution = TVCopy._resolution;
                _weight = TVCopy._weight;
                _warranty = TVCopy._warranty;
                _volume = TVCopy._volume;
                _brighnest = TVCopy._brighnest;
                _quantityHDMIPort = TVCopy._quantityHDMIPort;
                _quantityUSBPort = TVCopy._quantityUSBPort;
                _marka = TVCopy._marka;
                _model = TVCopy._model;
                _smartTV = TVCopy._smartTV;
                _isTvConect = TVCopy._isTvConect;
                _isTvOn = TVCopy._isTvOn;
                _isTvOnline = TVCopy._isTvOnline;


            }
            public void ConnectTV()
            {
                if(_isTvConect==false)
                {
                    _isTvConect = true;
                }
            }
            public void DisconnectTV()
            {
                if (_isTvConect == true)
                {
                    _isTvConect = false;
                }
            }
            public void TurnONTV()
            {
                if (_isTvConect == true && _isTvOn == false)
                {
                    _isTvOn = true;
                }
                else Console.WriteLine("TV not conetct");
            }
            public void TurnOFFTV()
            {
                if (_isTvConect == true && _isTvOn == true)
                {
                    _isTvOn = false;
                }
            }

        }
        class Monitor
        {
            private
            int _diagonal;
            string _resolution;
            int _responseTime;
            int _weight;
            int _warranty;
            int _brighnest;
            int _quantityHDMIPort;
            string _marka;
            string _model;
            string _type;
            string _color;
            bool _isMonitorConect = false;
            bool _isMonitorOn = false;
            
            public Monitor()
            {
                _diagonal = 18;
                _resolution = "1200x1300";
                _responseTime = 1;
                _weight = 8;
                _warranty = 2;
                _brighnest = 15;
                _quantityHDMIPort = 2;
                _marka = "Philips";
                _model = "PU18NW120";
                _type = "LCD";
                _color = "Black";
                _isMonitorConect = true;
                _isMonitorOn = false;
            }
            public Monitor(int responseTime, int quantityHDMIPort)
            {
                _diagonal = 18;
                _resolution = "1200x1300";
                _responseTime = responseTime;
                _weight = 8;
                _warranty = 2;
                _brighnest = 15;
                _quantityHDMIPort = quantityHDMIPort;
                _marka = "Philips";
                _model = "PU18NW120";
                _type = "LCD";
                _color = "Black";
                _isMonitorConect = true;
                _isMonitorOn = false ;
            }
            public Monitor(Monitor MonitorCopy)
            {
                _diagonal = MonitorCopy._diagonal;
                _resolution = MonitorCopy._resolution;
                _responseTime = MonitorCopy._responseTime;
                _weight = MonitorCopy._weight;
                _warranty = MonitorCopy._warranty;
                _brighnest = MonitorCopy._brighnest;
                _quantityHDMIPort = MonitorCopy._quantityHDMIPort;
                _marka = MonitorCopy._marka;
                _model = MonitorCopy._model;
                _type = MonitorCopy._type;
                _color = MonitorCopy._color;
                _isMonitorConect = MonitorCopy._isMonitorConect;
                _isMonitorOn = MonitorCopy._isMonitorOn;
            }
            public void TurnOnMonitor()
            {
                if(_isMonitorConect==true)
                {
                    _isMonitorOn = true;
                }
                else
                {
                    Console.WriteLine("Monitor is not conect!");
                }
            }
            public void AddMonitorBrighnest()
            {
                if(_isMonitorOn==true)
                {
                    if (_brighnest < 100)
                    {
                        _brighnest++;
                    }
                    else
                    {
                        Console.WriteLine("Brighnest max");
                    }
                }
            }
        }
        
        static void Main(string[] args)
        {
            TV myTV = new TV();
            TV myTV2 = new TV(42, "UE42N5002",true);
            TV myTV3 = new TV(myTV);
            myTV.ConnectTV();
            myTV.TurnONTV();


            Monitor myMonitor = new Monitor();
            Monitor myMonitor2 = new Monitor(1,2);
            Monitor myMonitor3 = new Monitor(myMonitor);

            myMonitor3.TurnOnMonitor();
            myMonitor3.AddMonitorBrighnest();
        }
    }
}
