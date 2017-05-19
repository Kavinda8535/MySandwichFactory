using System;

namespace MySandwitchFactory.Web.UI.Models
{
    public class CompanyDetailsViewModel
    {
        #region Constructors

        public CompanyDetailsViewModel()
        {
        }

        public CompanyDetailsViewModel(string companyName, string companyMoto, DateTime startDate)
        {
            CompanyName = companyName;
            CompanyMoto = companyMoto;
            StartDate = startDate;
        }

        #endregion

        public string CompanyName { get; set; }
        public string CompanyMoto { get; set; }
        public DateTime StartDate { get; set; }
    }
}