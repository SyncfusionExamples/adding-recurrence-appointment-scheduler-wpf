using Syncfusion.UI.Xaml.Scheduler;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Media;

namespace WpfScheduler
{
    public class SchedulerViewModel
    {
        public ScheduleAppointmentCollection scheduleAppointmentCollection { get; set; } = new ScheduleAppointmentCollection();
        public SchedulerViewModel()
        {
            var scheduleAppointment = new ScheduleAppointment()
            {
                Id = 1,
                StartTime = new DateTime(2020, 12, 13, 11, 0, 0),
                EndTime = new DateTime(2020, 12, 13, 12, 0, 0),
                Subject = "Occurs every alternate day",
                AppointmentBackground = Brushes.RoyalBlue,
                Foreground = Brushes.White,
            };
            scheduleAppointment.RecurrenceRule = "FREQ=DAILY;INTERVAL=2;COUNT=10";
            scheduleAppointmentCollection.Add(scheduleAppointment);
        }
    }
}
