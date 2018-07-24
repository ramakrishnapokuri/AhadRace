using System.ComponentModel.DataAnnotations;
namespace AheadRace.Models
{
    /// <summary>
    /// Date modal 
    /// </summary>
    public class Date
    {
        [Required(ErrorMessage ="Please enter start date.")] 
        [Display(Name ="Start Date")]
        [RegularExpression(@"^([0]?[0-9]|[12][0-9]|[3][01])[./-]([0]?[1-9]|[1][0-2])[./-]([0-9]{4}|[0-9]{2})$", ErrorMessage = "Please enter valid date.")]
        public string StartDate { get; set; }

        [Required(ErrorMessage = "Please enter End Date.")]
        [Display(Name = "End Date")]
        [RegularExpression(@"^([0]?[0-9]|[12][0-9]|[3][01])[./-]([0]?[1-9]|[1][0-2])[./-]([0-9]{4}|[0-9]{2})$",ErrorMessage = "Please enter valid date.")]
        public string EndDate { get; set; }       

        /// <summary>
        /// Get the diffrence between two dates in Days 
        /// </summary>
        /// <returns>diffrence in Days</returns>
        public long GetDateDiffrenceInDays()
        {
            long diffinDays = JulianDayNumber.ToJulian(EndDate) - JulianDayNumber.ToJulian(StartDate);
            return diffinDays;
        }
    }
}