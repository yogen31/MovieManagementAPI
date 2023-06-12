﻿using MovieManagementAPI.Generic;

namespace MovieManagementAPI.ViewModels
{
    public class MovieViewModel:GenericModel
    {
        public int MovieId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? UserId { get; set; }
        public int Genre { get; set; }
        public string? MovieLink { get; set; }
        public string? MediaPath { get; set; }
        public int AverageRating { get; set; }
        public int Total { get; set; }
        public int IsFavourite { get; set; }
        public List<MovieReviewViewModel>? MovieReviews { get; set; }
    }
}
