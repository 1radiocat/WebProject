using System;
using System.ComponentModel.DataAnnotations;
using WebProject.Domain.Base;

namespace WebProject.Domain
{
    public class Project : BaseEntity
    {
        /// <summary>
        /// Модель данных Проекта
        /// </summary>

        [Required(ErrorMessage = "Заполните название проекта"),
        Display(Name = "Название проекта")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Заполните наименование компании-заказчика"),
        Display(Name = "Заказчик"),
        MaxLength(500)]
        public string CompanyOwner { get; set; }

        [Display(Name = "Подрядчик"),
        MaxLength(500)]
        public string CompanyContractor { get; set; }

        [Display(Name = "Владелец"),
        MaxLength(500)]
        public string CompanyOwnerContactPerson { get; set; }

        [Display(Name = "Менеджер"),
        MaxLength(500)]
        public string CompanyContractorContactPerson { get; set; }

        [Display(Name = "Старт"),
        DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Display(Name = "Завершение"),
        DataType(DataType.Date)]
        public DateTime FinishDate { get; set; }

        [Display(Name = "Приоритет")]
        public int Priority { get; set; }
    }
}
