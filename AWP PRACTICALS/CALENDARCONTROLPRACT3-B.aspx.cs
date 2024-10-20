using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YourNamespace
{
    public partial class Vacation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CalendarStart.SelectedDate = DateTime.Today;
                CalendarEnd.SelectedDate = DateTime.Today;
            }
        }

        protected void CalendarStart_SelectionChanged(object sender, EventArgs e)
        {
            // Update start date when selected
            CalendarStart.SelectedDate = CalendarStart.SelectedDate;
        }

        protected void CalendarEnd_SelectionChanged(object sender, EventArgs e)
        {
            // Update end date when selected
            CalendarEnd.SelectedDate = CalendarEnd.SelectedDate;
        }

        protected void ButtonCalculate_Click(object sender, EventArgs e)
        {
            DateTime startDate = CalendarStart.SelectedDate;
            DateTime endDate = CalendarEnd.SelectedDate;

            // Validate the dates
            if (endDate < startDate)
            {
                LabelResult.Text = "End date must be after the start date.";
                return;
            }

            // Calculate the duration of the vacation
            TimeSpan vacationDuration = endDate - startDate;
            LabelResult.Text = $"Your vacation is {vacationDuration.Days + 1} days long.";

            // Highlight the vacation period on the calendars
            CalendarStart.DayRender += Calendar_DayRender;
            CalendarEnd.DayRender += Calendar_DayRender;
        }

        protected void Calendar_DayRender(object sender, DayRenderEventArgs e)
        {
            DateTime startDate = CalendarStart.SelectedDate;
            DateTime endDate = CalendarEnd.SelectedDate;

            // Highlight the days within the selected vacation period
            if (e.Day.Date >= startDate && e.Day.Date <= endDate)
            {
                e.Cell.BackColor = System.Drawing.Color.LightGreen;
            }
        }
    }
}
