﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreEntities.Entities
{
    public class Student : Person
    {
        #region Properties
        private static int studentsCount = 0;

        public virtual List<Subject> Subjects { get; set; }
        public int StudentNumber { get; set; }
        public bool HavePickUpService { get; set; } = false;
        public virtual Location Location { get; set; }
        #endregion

        public Student()
        {
            this.StudentNumber = ++studentsCount;
            base.Name = string.Empty;
            base.LastName = string.Empty;
            this.Subjects = new List<Subject>();
        }
        public Student(string name, string lastName, string documentNumber)
        {
            this.StudentNumber = ++studentsCount;
            this.Name = name;
            this.LastName = lastName;
            this.Document = documentNumber;
            this.Subjects = new List<Subject>();
        }

        #region Methods
        public string GetName()
        {
            return base.Name;
        }
        public string GetLastName()
        {
            return base.LastName;
        }
        public string GetDocumentNumber()
        {
            return base.Document;
        }
        public int GetStudentNumber()
        {
            return this.StudentNumber;
        }
        public void SetName(string newName)
        {
            base.Name = newName;
        }
        public void SetLastName(string newLastName)
        {
            base.LastName = newLastName;
        }
        public void SetPickUpService(bool pickup)
        {
            this.HavePickUpService = pickup;
        }
        public void SetLocation(Location studentLocation)
        {
            this.Location = studentLocation;
        }
        public Location GetLocation()
        {
            return this.Location;
        }
        public List<Subject> GetSubjects()
        {
            return this.Subjects;
        }
        public void ModifySubjects(List<Subject> newSubjects)
        {
            this.Subjects.Clear();
            foreach (Subject subject in newSubjects)
            {
                this.Subjects.Add(subject);
            }
        }
        public static int GetNextStudentNumber()
        {
            return studentsCount + 1;
        }
        #endregion

        public void AddSubjectToStudent(Subject newSubject)
        {
            this.Subjects.Add(newSubject);
        }
        public override bool Equals(object obj)
        {
            if (obj is Student)
                return this.GetDocumentNumber().Equals(((Student)obj).GetDocumentNumber());
            else
                return false;
        }
        public override string ToString()
        {
            return string.Format("Full name: {0}, Student number: {1}", this.GetFullName(), this.GetStudentNumber());
        }

        public string GetFullNameAndLocation()
        {
            return string.Format("{0}: {1}", this.GetFullName(), this.GetLocation());
        }
    }
}
