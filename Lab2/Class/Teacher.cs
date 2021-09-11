using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Class
{
    public class Teacher
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth;
        public string[] Languages;
        public string phoneNum;
        public string Mail;
        public string Sex;
        public Category SubjectCategory;

        public Teacher(string iD, string name, DateTime dateOfBirth, string[] languages, string phoneNum, string mail, string sex, Category subjectCategory)
        {
            ID = iD;
            Name = name;
            DateOfBirth = dateOfBirth;
            Languages = languages;
            this.phoneNum = phoneNum;
            Mail = mail;
            Sex = sex;
            SubjectCategory = subjectCategory;
        }

        public Teacher()
        {
            SubjectCategory = new Category();
            Languages = new string[10];
        }

        public override string ToString()
        {
            string s = String.Format($"Mã số: {this.ID}\nHọ Tên: {this.Name}\nNgày sinh: {this.DateOfBirth}\nGiới tính: {this.Sex}\nSố ĐT: {this.phoneNum}\nMail: {this.Mail}");
            string sLanguage = "Ngoại ngữ: ";
            foreach (var item in Languages) 
            {
                sLanguage += item + ";";
            }
            string sCategory = "DS môn dạy: ";
            foreach (var item in SubjectCategory.ls)
            {
                sCategory += item + ";";
            }
            return s+"\n"+sLanguage+ "\n"+ sCategory;
        }
    }
}
