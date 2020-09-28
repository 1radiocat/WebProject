using System.ComponentModel.DataAnnotations;
using WebProject.Domain.Base;

namespace WebProject.Domain
{
    public class EnumExecutorType : BaseEntity
    {
        /// <summary>
        /// Справочник типов Исполнителей
        /// </summary>

        [Display(Name = "Тип должности")]
        public string Type { get; set; }

        [Display(Name = "Описание")]
        public string Description { get; set; }
    }
}
