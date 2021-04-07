﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp.Models
{
    public class WeekModel : BaseModel
    {
        public DateTime StartDay { get; set; }
        public DateTime LastDay { get; set; }
        public string WeekString { get; set; }
    }

    public enum DayStateEnum
    {
        Active,
        Past,
        Future
    }

    public class DayModel: BaseModel
    {
        public DayStateEnum State { get; set; }
        public int Day { get; set; }
        public string DayName { get; set; }
        public DateTime Date { get; set; }
        public int Column { get; set; }
    }
}
