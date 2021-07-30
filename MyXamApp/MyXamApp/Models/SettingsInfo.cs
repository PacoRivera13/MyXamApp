using System.ComponentModel.DataAnnotations;

namespace MyXamApp.Models
{
   public class SettingsInfo
   {
      [Display(GroupName = "General")]
      public string UserName { get; set; }

      [Display(GroupName = "General")]
      public string Email { get; set; }

      [Display(GroupName = "General")]
      public string Password { get; set; }

      [Display(GroupName = "Business")]
      public string FarmNo { get; set; }

      [Display(GroupName = "Business")]
      public bool ActiveFlag { get; set; }
   }
}
