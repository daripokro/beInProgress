using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;


namespace BeInProgress.Model
{
    public class BookItem
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string Name { get; set; } // Название

        [Column(TypeName = "nvarchar(100)")]
        public string Author { get; set; } // Автор

        [Column(TypeName = "int")]
        public int Genre { get; set; } // Жанр (выбор из списка)

        [Column(TypeName = "nvarchar(200)")]
        public string Description { get; set; } // Описание 

        [Column(TypeName = "bit")]
        public bool Status { get; set; } // Статус(прочитана/непрочитана)
    }
}
