using System.ComponentModel.DataAnnotations;

namespace ShareMockups.DomainClasses
{
    public class ShareMockup
    {
        public int      ShareMockupId   { get; set; }
        [Display(Description="Name")]
        [Required(ErrorMessage ="The Name of the Mockup must be entered.")]
        public string   MockupName      { get; set; }
        [Required(ErrorMessage = "Url must be filled in.")]
        [Display(Description="URL")]
        [StringLength(150, MinimumLength =4, ErrorMessage = "URL must be greater than {2} characters and less than {1} characters")]
        public string   Url             { get; set; }
        [Required(ErrorMessage = "Description must be filled in.")]
        [StringLength(100, MinimumLength =4, ErrorMessage ="Description must be greater than {2} characters and less than {1} characters")]
        public string   Description     { get; set; }
        [Range(1,5, ErrorMessage = "Rate must be in between {1} and {2}")]
        public int      Rate            { get; set; }
        public bool     Available       { get; set; }
        public int      UserDefined     { get; set; }
        public bool     UserDefined2    { get; set; }
        public string   UserDefined3    { get; set; }
    }
}
