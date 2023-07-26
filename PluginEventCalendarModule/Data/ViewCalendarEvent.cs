﻿namespace CarrotCake.CMS.Plugins.EventCalendarModule.Data {

	public partial class ViewCalendarEvent {
		public Guid SiteID { get; set; }
		public Guid CalendarEventProfileId { get; set; }
		public Guid CalendarFrequencyId { get; set; }
		public Guid CalendarEventCategoryId { get; set; }
		public DateTime EventStartDate { get; set; }
		public DateTime EventEndDate { get; set; }
		public TimeSpan? EventStartTime { get; set; }
		public TimeSpan? EventEndTime { get; set; }
		public string? EventTitle { get; set; }
		public int? EventRepeatPattern { get; set; }
		public string? EventSeriesDetail { get; set; }
		public bool IsCancelledPublic { get; set; }
		public bool IsAllDayEvent { get; set; }
		public bool IsPublic { get; set; }
		public bool IsCancelledSeries { get; set; }
		public bool IsCancelledEvent { get; set; }
		public bool IsHoliday { get; set; }
		public bool IsAnnualHoliday { get; set; }
		public int RecursEvery { get; set; }
		public Guid CalendarEventId { get; set; }
		public DateTime EventDate { get; set; }
		public string? EventDetail { get; set; }
		public string FrequencyValue { get; set; } = null!;
		public string FrequencyName { get; set; } = null!;
		public int FrequencySortOrder { get; set; }
		public TimeSpan? EventStartTimeOverride { get; set; }
		public TimeSpan? EventEndTimeOverride { get; set; }
		public string CategoryFGColor { get; set; } = null!;
		public string CategoryBGColor { get; set; } = null!;
		public string CategoryName { get; set; } = null!;
	}
}