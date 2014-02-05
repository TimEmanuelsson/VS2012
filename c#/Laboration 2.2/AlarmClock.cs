using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_2._2
{
    class AlarmClock
    {
        //Värde för alarmtimmen
       private int _alarmHour;

        //Värde för alarmminuten
       private int _alarmMinute;

        //Värde för timmens klockslag
       private int _hour;

        //Värde för minutens klockslag
       private int _minute;

        public int AlarmHour
        {
            get
            {
                return _alarmHour;
            }
            set
            {
                if (value < 0 || value > 24)
                {
                    throw new AggregateException();
                }
                _alarmHour = value;
            }
            
        }

        public int AlarmMinute
        {
            get
            {
                return _alarmMinute;
            }
            set
            {
                if (value < 0 || value > 60)
                {
                    throw new AggregateException();
                }
                _alarmMinute = value;
            }
        }

        public int Hour
        {
            get
            {
                return _hour;
            }
            set
            {
                if (value < 0 || value > 24)
                {
                    throw new AggregateException();
                }
                _hour = value;
            }
        }

        public int Minute
        {
            get
            {
                return _minute;
            }
            set
            {
                if (value < 0 || value > 60)
                {
                    throw new AggregateException();
                }
                _minute = value;
            }
        }
        
        public AlarmClock() : this (0,0)
          {
          }       

        public AlarmClock(int hour, int minute) : this (hour, minute, 0, 0)
        {
        }

        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute)
        {
            Hour = hour;
            Minute = minute;
            AlarmHour = alarmHour;
            AlarmMinute = alarmMinute;
        }

        public bool TickTock()
        {
            if (Minute < 59)
            {
                Minute++;
            }

            else
            {
                Minute = 0;

                if (Hour < 23)
                {
                    Hour++;
                }
                else
                {
                    Hour = 0;
                }

            }

            return Minute == AlarmMinute && Hour == AlarmHour;
        }

        public override string ToString()
        {
            return String.Format("{0,2}:{1:D2} ({2}:{3:D2})", Hour, Minute, AlarmHour, AlarmMinute);

            //string min;
            //string alarmmin;

            //if (Minute >= 10)
            //{
            //    min = String.Format("{0}:{1}", Hour, Minute);
            //}
            //else
            //{
            //    min = String.Format("{0}:0{1}", Hour, Minute);
            //}

            //if (AlarmMinute >= 10)
            //{
            //    alarmmin = String.Format("{0}:{1}", AlarmHour, AlarmMinute);
            //}
            //else
            //{
            //    alarmmin = String.Format("{0}:0{1}", AlarmHour, AlarmMinute);
            //}

            //return String.Format("{0} ({1})", min, alarmmin);
        }

    }
}
