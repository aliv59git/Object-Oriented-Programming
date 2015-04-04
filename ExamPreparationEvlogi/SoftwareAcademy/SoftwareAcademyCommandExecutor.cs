﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftwareAcademy.Models;
using SoftwareAcademy.Interfaces;
using System.IO;

namespace SoftwareAcademy
{
    public class SoftwareAcademyCommandExecutor
    {
        static void Main(string[] args)
        {
            using (var sw = new StreamWriter("../../test.out.txt"))
            {
                Console.SetOut(sw);

                CourseFactory f = new CourseFactory();
                ITeacher joro = f.CreateTeacher("Joro");
                Console.WriteLine(joro);
                joro.Name = "George";
                Console.WriteLine(joro);
                ILocalCourse php = f.CreateLocalCourse("PHP", joro, "Enterprise");
                Console.WriteLine(php);
                php.AddTopic("Intro PHP");
                php.AddTopic("PHP Core");
                php.AddTopic("PHP Advanced Topics");
                php.AddTopic("PHP Exam");
                Console.WriteLine(php);
                IOffsiteCourse cpp = (new CourseFactory()).CreateOffsiteCourse("C++", joro, "Ultimate");
                Console.WriteLine(cpp);
                cpp.AddTopic("Intro C++");
                cpp.AddTopic("C++ Core");
                cpp.AddTopic("C++ Advanced Topics");
                cpp.AddTopic("C++ Exam");
                Console.WriteLine(cpp);
                joro.AddCourse(cpp);
                Console.WriteLine(joro);
                joro.AddCourse(php);
                joro.AddCourse(cpp);
                Console.WriteLine(joro);
                CourseFactory factory = new CourseFactory();
                ITeacher nakov = factory.CreateTeacher("Nakov");
                Console.WriteLine(nakov);
                nakov.Name = "Svetlin Nakov";
                Console.WriteLine(nakov);
                ILocalCourse oop = factory.CreateLocalCourse("OOP", null, "Light");
                Console.WriteLine(oop);
                oop.Teacher = nakov;
                Console.WriteLine(oop);
                oop.AddTopic("Using Classes and Objects");
                oop.AddTopic("Defining Classes");
                oop.AddTopic("OOP Principles");
                oop.AddTopic("Teamwork");
                oop.AddTopic("Exam Preparation");
                Console.WriteLine(oop);
                ICourse html = factory.CreateOffsiteCourse("HTML", nakov, "Plovdiv");
                html.AddTopic("Using Classes and Objects");
                Console.WriteLine(html);
                html.AddTopic("Defining Classes");
                html.AddTopic("OOP Principles");
                Console.WriteLine(html);
                html.AddTopic("Teamwork");
                html.AddTopic("Exam Preparation");
                Console.WriteLine(html);
                nakov.AddCourse(oop);
                nakov.AddCourse(html);
                Console.WriteLine(nakov);
                oop.Name = "Object-Oriented Programming";
                (oop as ILocalCourse).Lab = "Enterprise";
                oop.Teacher = factory.CreateTeacher("George Georgiev");
                oop.AddTopic("Practical Exam");
                Console.WriteLine(oop);
                html.Name = "HTML Basics";
                (html as IOffsiteCourse).Town = "Varna";
                html.Teacher = oop.Teacher;
                html.AddTopic("Practical Exam");
                Console.WriteLine(html);
                ICourse css = factory.CreateLocalCourse("CSS", null, "Ultimate");
                Console.WriteLine(css);
                for (int i = 0; i < 2; i++)
                {
                    joro.AddCourse(oop);
                    joro.AddCourse(oop);
                    joro.AddCourse(css);
                }
                Console.WriteLine(joro);
                php.Name = "PHP Avdanced Course";
                ILocalCourse localPhp = (ILocalCourse)php;
                localPhp.Lab = "The Very Big Lab";
                php.Teacher = nakov;
                php.AddTopic("Final PHP Topic");
                Console.WriteLine(php);
                html.Name = "PHP Avdanced Course";
                IOffsiteCourse offsiteHtml = (IOffsiteCourse)html;
                offsiteHtml.Town = "The Very Big Lab";
                html.Teacher = null;
                html.AddTopic("Final HTML Topic");
                Console.WriteLine(html.ToString());


            }

        }
    }
}
