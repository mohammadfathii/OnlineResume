﻿using System.ComponentModel.DataAnnotations;

namespace OnlineResume.Models
{
	public class Education
	{
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
    }
}