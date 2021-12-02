using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.ComponentModel;
using Microsoft.AspNetCore.Http;

namespace StudentsDataBase.Models
{

    public enum Specialities
    {
        Programmer,
        Desighner
    }

    public enum Faculties
    {
        Programming,
        Design
    }

    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(20, MinimumLength = 2, ErrorMessage = "Minimum length of the name - 2, maximum length of the name - 20")]
        public string Name { get; set; }
        [Required, StringLength(20, MinimumLength = 2, ErrorMessage = "Minimum length of the surname - 2, maximum length of the surname - 20")]
        public string Surname { get; set; }
        [Required, StringLength(20, MinimumLength = 2, ErrorMessage = "Minimum length of the patronymic - 2, maximum length of the patronymic - 20")]
        public string Patronymic { get; set; }
        [Required, Range(1,5, ErrorMessage = "Course value can be only in range from 1 to 5")]
        public int Course { get; set; }
        [Required, StringLength(5, MinimumLength = 3, ErrorMessage = "Impossible group")]
        public string Group { get; set; }
        [Required(ErrorMessage = "You can`t left Speciality field empty")]
        public Specialities Speciality { get; set; }
        [Required(ErrorMessage = "You can`t left Faculty field empty")]
        public Faculties Faculty { get; set; }
        [DataType(DataType.Date), Required(ErrorMessage = "You have to choose your birth date"), Display(Name = "Birth Date")]
        public DateTime BirthDate { get; set; }
        [Required, StringLength(30, MinimumLength = 5, ErrorMessage = "Minimum length of the adress - 5, maximum length of the adress - 30")]
        public string Adress { get; set; }
        [Required, StringLength(13, MinimumLength = 13, ErrorMessage = "Incorrect phone number")]
        public string Phone { get; set; }
    }
}
