using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebProject.Domain.Base
{
    public class BaseEntity
    {
        /// <summary>
        /// Базовая сущность с автогенерацией Id
        /// </summary>

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
    }
}
