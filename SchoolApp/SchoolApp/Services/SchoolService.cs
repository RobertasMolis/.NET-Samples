﻿using SchoolApp.Dtos;
using SchoolApp.Models;
using SchoolApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Services
{
    public class SchoolService
    {
        private SchoolRepository _schoolRepository;
        private StudentRepository _studentRepository;

        public SchoolService(SchoolRepository schoolRepository, StudentRepository studentRepository)
        {
            _schoolRepository = schoolRepository;
            _studentRepository = studentRepository;
        }

        public void Create(string name)
        {
            School newSchool = new School()
            {
                Name = name,
                Created = DateTime.Now,
            };

            _schoolRepository.Create(newSchool);
        }

        public List<SchoolDto> GetAll()
        {
            List<SchoolDto> schoolDtos = new List<SchoolDto>();
            List<School> schools = _schoolRepository.GetAllIncluded();
            
            foreach(var school in schools)
            {
                SchoolDto schoolDto = new SchoolDto()
                {
                    SchoolName = school.Name,
                    SchoolCreated = school.Created,
                    Students = ParseToDto(school.Students)
                };

                schoolDtos.Add(schoolDto);
            }

            return schoolDtos;
        }

        public SchoolDto GetById(int id)
        {
            School school = _schoolRepository.GetByIdIncluded(id);

            SchoolDto schoolDto = new SchoolDto()
            {
                SchoolName= school.Name,
                SchoolCreated= school.Created,
                Students = ParseToDto(school.Students)
            };

            return schoolDto;
        }

        public void Update(int id, string newName)
        {
            School school = _schoolRepository.GetById(id);
            school.Name = newName;

            _schoolRepository.Update(school);
        }

        public void Remove(int id)
        {
            _schoolRepository.Remove(id);
        }

        private List<StudentDto> ParseToDto(List<Student> students)
        {
            List<StudentDto> studentDtos = new List<StudentDto>();

            foreach(var student in students)
            {
                StudentDto studentDto = new StudentDto()
                {
                    StudentName = student.Name,
                    Sex = student.Sex,
                    SchoolId = student.SchoolId
                };
                studentDtos.Add(studentDto);
            }

            return studentDtos;
        }
    }
}
