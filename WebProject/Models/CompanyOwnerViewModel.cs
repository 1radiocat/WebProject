using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using WebProject.Domain;

namespace WebProject.Models
{
    public class CompanyOwnerViewModel
    {
        /// <summary>
        /// Поиск проекта по компании-заказчику
        /// </summary>

        public List<Project> Projects { get; set; }
        public SelectList CompanyOwners { get; set; }
        public string ProjectCompanyOwner { get; set; }
        public string SearchString { get; set; }
    }
}
