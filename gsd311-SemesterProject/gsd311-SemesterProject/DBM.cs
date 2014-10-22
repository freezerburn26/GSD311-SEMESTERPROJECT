using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace gsd311_SemesterProject
{
    public class DBM
    {
        /// <summary>
        /// Returns an array of students in the database.
        /// </summary>
        /// <returns>(Student[]) Array of students in the database.</returns>
        public Student[] getStudentInfo()
        {
            Student[] tempStudents;
            List<Student> studentList = new List<Student>();
            Course[] tempCourses;
            bool tempBool;
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.testConnectionString))
            {
                con.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand("select * from Student", con))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Student temp = new Student();
                            string tempStr;
                            temp.StudentId = reader.GetInt32(0);
                            temp.FirstName = reader.GetString(1);
                            temp.LastName = reader.GetString(2);
                            temp.GPA = (double)reader.GetDecimal(3);
                            tempStr = reader.GetString(4);
                            temp.setAPStudy(tempStr);
                            temp.StudentNum = reader.GetString(5);
                            bool.TryParse(reader.GetString(6), out tempBool);
                            temp.Eligable = tempBool;

                            tempCourses = getEnrolledCoursesForStudent(reader.GetInt32(0));
                            foreach(Course takenCourse in tempCourses)
                            {
                                temp.addCourse(takenCourse);
                            }
                  
                            studentList.Add(temp);

                        }
                    }


                }
                catch (Exception es)
                {
                    throw es;
                }
                finally
                {
                    con.Close();
                }

            }

            tempStudents = studentList.ToArray();
            return tempStudents;
        }


        /// <summary>
        /// Returns an array of courses for a particular student
        /// </summary>
        /// <param name="StudentId">The student whose courses you want</param>
        /// <returns>(Course[])Course array for the student</returns>
        public Course[] getEnrolledCoursesForStudent(int StudentId)
        {
            Course[] tempCoursesArray;
            List<Course> tempCourses = new List<Course>();

            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.testConnectionString))
            {
                con.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand("Select Courses.CourseName, EnrolledCourses.CourseGrade, Courses.CourseNum, Courses.CreditHours, Courses.CourseType, Courses.id from Courses, EnrolledCourses WHERE Courses.id = EnrolledCourses.CourseId and EnrolledCourses.StudentId = " + StudentId, con))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            string tempStr;
                            Course tempCourse = new Course();
                            tempCourse.CourseName = reader.GetString(0);
                            tempCourse.GPA = (double)reader.GetDecimal(1);
                            tempCourse.CourseNum = reader.GetString(2);
                            tempCourse.CreditHours = reader.GetInt32(3);
                            tempStr = reader.GetString(4);
                            tempCourse.CourseId = reader.GetInt32(5);

                            if (tempStr.Equals("MathSci"))
                            {
                                //tempCourse = (MathSci) tempCourse;
                                MathSci tempMathSci = new MathSci();
                                tempMathSci.CourseName = tempCourse.CourseName;
                                tempMathSci.CourseNum = tempCourse.CourseNum;
                                tempMathSci.CreditHours = tempCourse.CreditHours;
                                tempMathSci.GPA = tempCourse.GPA;
                                tempMathSci.CourseId = tempCourse.CourseId;
                                tempCourses.Add(tempMathSci);
                            }
                            if (tempStr.Equals("Core"))
                            {
                                //tempCourse = (Core) tempCourse;
                                Core tempCore = new Core();
                                tempCore.CourseName = tempCourse.CourseName;
                                tempCore.CourseNum = tempCourse.CourseNum;
                                tempCore.CreditHours = tempCourse.CreditHours;
                                tempCore.GPA = tempCourse.GPA;
                                tempCore.CourseId = tempCourse.CourseId;
                                tempCourses.Add(tempCore);
                            }
                            if (tempStr.Equals("Communication"))
                            {
                                //tempCourse = (Communication) tempCourse;
                                Communication tempCommunication = new Communication();
                                tempCommunication.CourseName = tempCourse.CourseName;
                                tempCommunication.CourseNum = tempCourse.CourseNum;
                                tempCommunication.CreditHours = tempCourse.CreditHours;
                                tempCommunication.GPA = tempCourse.GPA;
                                tempCommunication.CourseId = tempCourse.CourseId;
                                tempCourses.Add(tempCommunication);
                            }
                            if (tempStr.Equals("General"))
                            {
                                //tempCourse = (General) tempCourse;
                                General tempGeneral = new General();
                                tempGeneral.CourseName = tempCourse.CourseName;
                                tempGeneral.CourseNum = tempCourse.CourseNum;
                                tempGeneral.CreditHours = tempCourse.CreditHours;
                                tempGeneral.GPA = tempCourse.GPA;
                                tempGeneral.CourseId = tempCourse.CourseId;
                                tempCourses.Add(tempGeneral);
                            }


                        }
                    }
                }
                catch (Exception es)
                {
                    throw es;
                }
                finally
                {
                    con.Close();
                }
            }

            tempCoursesArray = tempCourses.ToArray();
            return tempCoursesArray;
        }

        /// <summary>
        /// This returns an array of the courses in the database
        /// </summary>
        /// <returns>(Course[]) Courses in database.</returns>
        public Course[] getAllCourses()
        {
            Course[] tempArr;
            List<Course> courseList = new List<Course>();

            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.testConnectionString))
            {
                con.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand("Select * from Courses", con))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            string tempStr;
                            Course tempCourse = new Course();
                            tempCourse.CourseName = reader.GetString(1);
                            tempCourse.CourseNum = reader.GetString(2);
                            tempCourse.CreditHours = reader.GetInt32(3);
                            tempStr = reader.GetString(4);
                            tempCourse.CourseId = reader.GetInt32(0);

                            if (tempStr.Equals("MathSci"))
                            {
                                //tempCourse = (MathSci) tempCourse;
                                MathSci tempMathSci = new MathSci();
                                tempMathSci.CourseName = tempCourse.CourseName;
                                tempMathSci.CourseNum = tempCourse.CourseNum;
                                tempMathSci.CreditHours = tempCourse.CreditHours;
                                tempMathSci.GPA = tempCourse.GPA;
                                tempMathSci.CourseId = tempCourse.CourseId;
                                courseList.Add(tempMathSci);
                            }
                            if (tempStr.Equals("Core"))
                            {
                                //tempCourse = (Core) tempCourse;
                                Core tempCore = new Core();
                                tempCore.CourseName = tempCourse.CourseName;
                                tempCore.CourseNum = tempCourse.CourseNum;
                                tempCore.CreditHours = tempCourse.CreditHours;
                                tempCore.GPA = tempCourse.GPA;
                                tempCore.CourseId = tempCourse.CourseId;
                                courseList.Add(tempCore);
                            }
                            if (tempStr.Equals("Communication"))
                            {
                                //tempCourse = (Communication) tempCourse;
                                Communication tempCommunication = new Communication();
                                tempCommunication.CourseName = tempCourse.CourseName;
                                tempCommunication.CourseNum = tempCourse.CourseNum;
                                tempCommunication.CreditHours = tempCourse.CreditHours;
                                tempCommunication.GPA = tempCourse.GPA;
                                tempCommunication.CourseId = tempCourse.CourseId;
                                courseList.Add(tempCommunication);
                            }
                            if (tempStr.Equals("General"))
                            {
                                //tempCourse = (General) tempCourse;
                                General tempGeneral = new General();
                                tempGeneral.CourseName = tempCourse.CourseName;
                                tempGeneral.CourseNum = tempCourse.CourseNum;
                                tempGeneral.CreditHours = tempCourse.CreditHours;
                                tempGeneral.GPA = tempCourse.GPA;
                                tempGeneral.CourseId = tempCourse.CourseId;
                                courseList.Add(tempGeneral);
                            }


                        }
                    }
                }
                catch (Exception es)
                {
                    throw es;
                }
                finally
                {
                    con.Close();
                }
            }

            tempArr = courseList.ToArray();
            return tempArr;


        }

        /// <summary>
        /// This returns the total number of students in the database.
        /// </summary>
        /// <returns>(int)Total number of students in the database</returns>
        public int getTotalStudents()
        {
            int count = 0;
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.testConnectionString))
            {
                con.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand("select * from Student", con))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            count += 1;

                        }
                    }


                }
                catch (Exception es)
                {
                    throw es;
                }
                finally
                {
                    con.Close();
                }

            }
            return count;

        }

        /// <summary>
        /// Enters a new student into the database.
        /// </summary>
        /// <param name="tempStudent">The student you want entered.</param>
        public void writeNewStudentInfo(Student tempStudent)
        {
            string tempFirstName = tempStudent.FirstName;
            string tempLastName = tempStudent.LastName;
            double tempGPA = tempStudent.GPA;
            string tempStudy = tempStudent.APStudy.ToString();
            string tempStudentNum = tempStudent.StudentNum;
            string tempStatus = tempStudent.Eligable.ToString();
            Course[] tempCourses = tempStudent.GetCourseList().ToArray();
            
            int studentCount = getTotalStudents();
            int tempStudentId = tempStudent.StudentId;
            

            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.testConnectionString))
            {
                con.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand(
                    "INSERT INTO Student (Fname, LName, GPA, Study, StudentID, Status) VALUES (@FName, @LName, @GPA, @Study, @StudentID, @Status)", con))
                    {
                        command.Parameters.Add(new SqlParameter("FName", tempFirstName));
                        command.Parameters.Add(new SqlParameter("LName", tempLastName));
                        command.Parameters.Add(new SqlParameter("GPA", tempGPA));
                        command.Parameters.Add(new SqlParameter("Study", tempStudy.ToString()));
                        command.Parameters.Add(new SqlParameter("StudentID", tempStudentNum));
                        command.Parameters.Add(new SqlParameter("Status", tempStatus));
                        command.ExecuteNonQuery();
                    }
                }
                catch(Exception es)
                {
                    throw es;
                }
                finally
                {
                    con.Close();
                }



            }
            
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.testConnectionString))
            {
                con.Open();
                try
                {
                    foreach (Course tempCourse in tempCourses)
                    {
                        using (SqlCommand command = new SqlCommand(
                    "INSERT INTO EnrolledCourses (StudentId, CourseId, CourseGrade) VALUES (@StudentId, @CourseId, @CourseGrade)", con))
                        {
                            command.Parameters.Add(new SqlParameter("StudentId", tempStudentId));
                            command.Parameters.Add(new SqlParameter("CourseId", tempCourse.CourseId));
                            command.Parameters.Add(new SqlParameter("CourseGrade",tempCourse.GPA));
                            command.ExecuteNonQuery();
                        }
                    }
                    
                }
                catch (Exception es)
                {
                    throw es;
                }
                finally
                {
                    con.Close();
                }
            }
        }

        /// <summary>
        /// Updates a students information in the database.
        /// </summary>
        /// <param name="tempStudent">The student you wish to update.</param>
        public void updateStudentInfo(Student tempStudent)
        {
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.testConnectionString))
            {
                con.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand("DELETE FROM EnrolledCourses WHERE StudentId = " + tempStudent.StudentId, con))
                    {
                        command.ExecuteNonQuery();
                    }
                    using (SqlCommand command = new SqlCommand("DELETE FROM Student WHERE id = " + tempStudent.StudentId, con))
                    {
                        command.ExecuteNonQuery();
                    }

                    using (SqlCommand command = new SqlCommand("SET IDENTITY_INSERT Student ON", con))
                    {
                        command.ExecuteNonQuery();
                    }

                    
                    using (SqlCommand command = new SqlCommand(
                    "INSERT INTO Student (id, Fname, LName, GPA, Study, StudentID, Status) VALUES (@id, @FName, @LName, @GPA, @Study, @StudentID, @Status)", con))
                    {
                        command.Parameters.Add(new SqlParameter("id", tempStudent.StudentId));
                        command.Parameters.Add(new SqlParameter("FName", tempStudent.FirstName));
                        command.Parameters.Add(new SqlParameter("LName", tempStudent.LastName));
                        command.Parameters.Add(new SqlParameter("GPA", tempStudent.GPA));
                        command.Parameters.Add(new SqlParameter("Study", tempStudent.APStudy.ToString()));
                        command.Parameters.Add(new SqlParameter("StudentID", tempStudent.StudentNum));
                        command.Parameters.Add(new SqlParameter("Status", tempStudent.Eligable));
                        command.ExecuteNonQuery();
                    }
                    foreach (Course tempCourse in tempStudent.GetCourseList().ToArray())
                    {
                        using (SqlCommand command = new SqlCommand(
                    "INSERT INTO EnrolledCourses (StudentId, CourseId, CourseGrade) VALUES (@StudentId, @CourseId, @CourseGrade)", con))
                        {
                            command.Parameters.Add(new SqlParameter("StudentId", tempStudent.StudentId));
                            command.Parameters.Add(new SqlParameter("CourseId", tempCourse.CourseId));
                            command.Parameters.Add(new SqlParameter("CourseGrade", tempCourse.GPA));
                            command.ExecuteNonQuery();
                        }
                    }
                    using (SqlCommand command = new SqlCommand("SET IDENTITY_INSERT Student OFF", con))
                    {
                        command.ExecuteNonQuery();
                    }

                }
                catch (Exception es)
                {
                    throw es;
                }
                finally
                {
                    con.Close();
                }
            }
        }

        /// <summary>
        /// Returns the last key used by the student table.
        /// </summary>
        /// <returns>int last key</returns>
        public int getLastStudentId()
        {
            //string command = "SELECT MAX(id) FROM Student";
            int lastID = 0;

            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.testConnectionString))
            {
                con.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand("SELECT MAX(id) FROM Student", con))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            lastID = reader.GetInt32(0);
                        }
                    }


                }
                catch (Exception es)
                {
                    throw es;
                }
                finally
                {
                    con.Close();
                }

            }
            return lastID;
        }
    }
}
