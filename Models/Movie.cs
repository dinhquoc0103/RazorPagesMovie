using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        // ID phim
        public int ID { get; set; }
        //Tên phim 
        public string Title { get; set; }

        // Ngày phát hành
        [DataType(DataType.Date)]   // Validate là ngày
        public DateTime ReleaseDate { get; set; }
        // Thể loại phim
        public string Genre { get; set; }
        //Giá
        public decimal Price { get; set; }
    }
}
