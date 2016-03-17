using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace GolfCardReader.Models
{
    public class Card
    {

        public int ID { get; set; }

        [Display(Name = "Player")]
        public string PlayerName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [Range(1, 12)]
        public int? Score1 { get; set; }

        [Range(1, 12)]
        public int? Score2 { get; set; }

        [Range(1, 12)]
        public int? Score3 { get; set; }

        [Range(1, 12)]
        public int? Score4 { get; set; }

        [Range(1, 12)]
        public int? Score5 { get; set; }

        [Range(1, 12)]
        public int? Score6 { get; set; }

        [Range(1, 12)]
        public int? Score7 { get; set; }

        [Range(1, 12)]
        public int? Score8 { get; set; }

        [Range(1, 12)]
        public int? Score9 { get; set; }

        public int Par3 = 3;
        public int Par4 = 4;
        public int Par5 = 5;
        

        [Display(Name = "Tee Off")]
        public TeeOff teeOff { get; set; }
        public enum TeeOff : int { Blue, White, Gold, Red }
    }

    public class GolfCardDBContext : DbContext
    {
        public DbSet<Card> Cards { get; set; }
    }

}