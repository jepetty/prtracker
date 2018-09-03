﻿namespace PRTrackerUI.Models
{
    internal class TrackerConfig
    {
        public double Version { get; set; }

        public TrackerReviewTool[] ReviewTools { get; set; }

        public string DefaultReviewTool { get; set; }

        public TrackerQuery[] Queries { get; set; }
    }
}