﻿using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ReminderMapping
{
    public class Meeting : NotificationObject
    {
        DateTime from, to;
        string eventName;
        bool isAllDay;
        string startTimeZone, endTimeZone;
        Brush color;
        private ObservableCollection<DateTime> recurrenceExceptionDates = new ObservableCollection<DateTime>();
        private string rRUle;
        private object recurrenceId;
        private object id;
        private ObservableCollection<object> resources;
        private string notes;
        private string timeValue;
        private ObservableCollection<Reminder> reminders;
        private Brush foreground;

        public Meeting()
        {
        }

        public DateTime From
        {
            get { return from; }
            set
            {
                from = value;
                RaisePropertyChanged("From");
            }
        }

        public DateTime To
        {
            get { return to; }
            set
            {
                to = value;
                RaisePropertyChanged("To");
            }
        }

        public bool IsAllDay
        {
            get { return isAllDay; }
            set
            {
                isAllDay = value;
                RaisePropertyChanged("IsAllDay");
            }
        }
        public string EventName
        {
            get { return eventName; }
            set
            {
                eventName = value;
                RaisePropertyChanged("EventName");
            }
        }

        public string Notes
        {
            get { return notes; }
            set
            {
                notes = value;
                RaisePropertyChanged("Notes");
            }
        }
        public string StartTimeZone
        {
            get { return startTimeZone; }
            set
            {
                startTimeZone = value;
                RaisePropertyChanged("StartTimeZone");
            }
        }
        public string EndTimeZone
        {
            get { return endTimeZone; }
            set
            {
                endTimeZone = value;
                RaisePropertyChanged("EndTimeZone");
            }
        }

        public Brush Color
        {
            get { return color; }
            set
            {
                color = value;
                RaisePropertyChanged("Color");
            }
        }

        public object RecurrenceId
        {
            get { return recurrenceId; }
            set
            {
                recurrenceId = value;
                RaisePropertyChanged("RecurrenceId");
            }
        }

        public object Id
        {
            get { return id; }
            set
            {
                id = value;
                RaisePropertyChanged("Id");
            }
        }

        public string RecurrenceRule
        {
            get { return rRUle; }
            set
            {
                rRUle = value;
                RaisePropertyChanged("RecurrenceRule");
            }
        }

        public ObservableCollection<DateTime> RecurrenceExceptions
        {
            get { return recurrenceExceptionDates; }
            set
            {
                recurrenceExceptionDates = value;
                RaisePropertyChanged("RecurrenceExceptions");
            }
        }

        public ObservableCollection<Reminder> Reminders
        {
            get { return reminders; }
            set
            {
                reminders = value;
                this.RaisePropertyChanged("Reminders");
            }
        }
    }
}
