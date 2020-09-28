using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WebProject.Domain.Base;

namespace WebProject.Domain
{
    public class Executor : BaseEntity
    {
        /// <summary>
        /// Модель данных Сотрудника
        /// </summary>

        [Required(ErrorMessage = "Заполните Ф.И.О. сотрудника"),
        Display(Name = "Ф.И.О.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Заполните должность сотрудника"),
        Display(Name = "Должность")]
        public string ExecutorType { get; set; }
        //public EnumExecutorType Type { get; set; }

        [Display(Name = "Проект")]
        public Guid ProjectId { get; set; }
        //public Project Project { get; set; }

        [Display(Name = "Задачи")]
        public Guid TaskId { get; set; }
        //public List<Task> Tasks { get; set; }
    }
}
