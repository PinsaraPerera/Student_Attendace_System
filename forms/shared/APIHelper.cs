using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace StudentsManagementSystemForm.shared
{
    public static class APIHelper
    {
        // Base URL for the API
        public static readonly string baseURL = "https://fastapi-backend-2meuzsegna-uc.a.run.app";

        

        // Method to update an existing student
        public static async Task<string> UpdateItem(string studentNumber, string studentName, string degreeId, string specializationID, string studentemail, string studentfaculty, string departmentId, string studentimage, string startingYear)
        {
            var inputData = new
            {
                student_no = studentNumber,
                student_name = studentName,
                degree_id = degreeId,
                specialization_id = specializationID,
                email = studentemail,
                faculty = studentfaculty,
                department_id = departmentId,
                image = studentimage,
                starting_yr = startingYear
            };
            var json = JsonConvert.SerializeObject(inputData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string updateURL = $"{baseURL}/student/update/{studentNumber}"; // Correct URL for updating a student
                    using (HttpResponseMessage res = await client.PutAsync(updateURL, content))
                    {
                        string data = await res.Content.ReadAsStringAsync();
                        Console.WriteLine("Status Code: " + res.StatusCode);
                        Console.WriteLine("Response: " + data);

                        if (res.IsSuccessStatusCode)
                        {
                            return data;
                        }
                        else
                        {
                            Console.WriteLine("Failed to update student. Status Code: " + res.StatusCode);
                            return string.Empty;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return string.Empty;
                }
            }
        }

        // Method to update an existing faculty
        public static async Task<string> UpdateFaculty(string facultyID, string facultyName)
        {
            var inputData = new
            {
                id = facultyID,
                name = facultyName,
            };
            var json = JsonConvert.SerializeObject(inputData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string updateURL = $"{baseURL}/faculty/update/{facultyID}"; // Correct URL for updating a student
                    using (HttpResponseMessage res = await client.PutAsync(updateURL, content))
                    {
                        string data = await res.Content.ReadAsStringAsync();
                        Console.WriteLine("Status Code: " + res.StatusCode);
                        Console.WriteLine("Response: " + data);

                        if (res.IsSuccessStatusCode)
                        {
                            return data;
                        }
                        else
                        {
                            Console.WriteLine("Failed to update student. Status Code: " + res.StatusCode);
                            return string.Empty;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return string.Empty;
                }
            }
        }

        // Method to update an existing subject
        public static async Task<string> UpdateSubject(string lectureCode, string lectureName, string degree, string year)
        {
            var inputData = new
            {
                subject_code = lectureCode,
                subject_name = lectureName,
                degree = degree,
                year = year
            };
            var json = JsonConvert.SerializeObject(inputData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {


                try
                {
                    string updateURL = $"{baseURL}/subject/update/{lectureCode}"; // Correct URL for updating a student
                    using (HttpResponseMessage res = await client.PutAsync(updateURL, content))
                    {
                        string data = await res.Content.ReadAsStringAsync();
                        Console.WriteLine("Status Code: " + res.StatusCode);
                        Console.WriteLine("Response: " + data);

                        if (res.IsSuccessStatusCode)
                        {
                            return data;
                        }
                        else
                        {
                            Console.WriteLine("Failed to update subject. Status Code: " + res.StatusCode);
                            return string.Empty;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return string.Empty;
                }
            }
        }

        // Method to update an existing Lecture
        public static async Task<string> UpdateLecture(string lectID, string facultyName, string degreeProgram, string academicYear, string subjectCode, string lecturersID, string lectureHall, string lectureDay, string lectureStart, string lectureEnd)
        {
            var inputData = new
            {
                id = lectID,
                academic_year = academicYear,
                day = lectureDay,
                degree = degreeProgram,
                faculty = facultyName,
                lecture_hall = lectureHall,
                subject_code = subjectCode,
                teacher_id = lecturersID,
                time_slot = new
                {
                    end_time = lectureEnd,
                    start_time = lectureStart
                }
            };
            var json = JsonConvert.SerializeObject(inputData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {


                try
                {
                    string updateURL = $"{baseURL}/lecture/update/{lectID}"; // Correct URL for updating a student
                    using (HttpResponseMessage res = await client.PutAsync(updateURL, content))
                    {
                        string data = await res.Content.ReadAsStringAsync();
                        Console.WriteLine("Status Code: " + res.StatusCode);
                        Console.WriteLine("Response: " + data);

                        if (res.IsSuccessStatusCode)
                        {
                            return data;
                        }
                        else
                        {
                            Console.WriteLine("Failed to update subject. Status Code: " + res.StatusCode);
                            return string.Empty;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return string.Empty;
                }
            }
        }

        // Method to update an existing Teacher
        public static async Task<string> UpdateTeacher(string teacherid, string teacherDepartment, string teacherName, string teacherEmail)
        {
            var inputData = new
            {
                id = teacherid,
                department = teacherDepartment,
                name = teacherName,
                email = teacherEmail,
            };
            var json = JsonConvert.SerializeObject(inputData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {


                try
                {
                    string updateURL = $"{baseURL}/teacher/update/{teacherid}"; // Correct URL for updating a student
                    using (HttpResponseMessage res = await client.PutAsync(updateURL, content))
                    {
                        string data = await res.Content.ReadAsStringAsync();
                        Console.WriteLine("Status Code: " + res.StatusCode);
                        Console.WriteLine("Response: " + data);

                        if (res.IsSuccessStatusCode)
                        {
                            return data;
                        }
                        else
                        {
                            Console.WriteLine("Failed to update subject. Status Code: " + res.StatusCode);
                            return string.Empty;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return string.Empty;
                }
            }
        }


        // Method to add a new student
        public static async Task<string> Post(string studentNumber, string studentName, string degreeId, string specializationID, string email, string faculty, string departmentId, string image, string startingYear)
        {
            var inputData = new
            {
                student_no = studentNumber,
                student_name = studentName,
                degree_id = degreeId,
                specialization_id = specializationID,
                email = email,
                faculty = faculty,
                department_id = departmentId,
                image = image,
                starting_yr = startingYear
            };
            var json = JsonConvert.SerializeObject(inputData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string postURL = $"{baseURL}/student/create"; // Correct URL for adding a new student

                    using (HttpResponseMessage res = await client.PostAsync(postURL, content))
                    {
                        res.EnsureSuccessStatusCode(); // Throw if not a success code.
                        string data = await res.Content.ReadAsStringAsync();
                        Console.WriteLine("Response: " + data);
                        return data;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return string.Empty;
                }
            }
        }

     

        // Method to add a new subject
        public static async Task<string> Post(string lectureCode, string lectureName, string degree, string year)
        {
            var inputData = new
            {
                subject_code = lectureCode,
                subject_name = lectureName,
                degree = degree,
                year = year

            };
            var json = JsonConvert.SerializeObject(inputData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string postURL = $"{baseURL}/subject/create"; // Correct URL for adding a new student

                    using (HttpResponseMessage res = await client.PostAsync(postURL, content))
                    {
                        res.EnsureSuccessStatusCode(); // Throw if not a success code.
                        string data = await res.Content.ReadAsStringAsync();
                        Console.WriteLine("Response: " + data);
                        return data;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return string.Empty;
                }
            }
        }

        // Method to add a new faculty
        public static async Task<string> PostFaculty(string facultyID, string facultyName)
        {
            var inputData = new
            {
                id = facultyID,
                name = facultyName,
                
            };
            var json = JsonConvert.SerializeObject(inputData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string postURL = $"{baseURL}/faculty/create"; // Correct URL for adding a new student

                    using (HttpResponseMessage res = await client.PostAsync(postURL, content))
                    {
                        res.EnsureSuccessStatusCode(); // Throw if not a success code.
                        string data = await res.Content.ReadAsStringAsync();
                        Console.WriteLine("Response: " + data);
                        return data;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return string.Empty;
                }
            }
        }

        // Method to add a new teacher
        public static async Task<string> PostTeacher(string teacherDepartment, string teacherName, string teacherEmail)
        {
            var inputData = new
            {
                department = teacherDepartment,
                name = teacherName,
                email = teacherEmail,

            };
            var json = JsonConvert.SerializeObject(inputData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string postURL = $"{baseURL}/teacher/create"; // Correct URL for adding a new student

                    using (HttpResponseMessage res = await client.PostAsync(postURL, content))
                    {
                        res.EnsureSuccessStatusCode(); // Throw if not a success code.
                        string data = await res.Content.ReadAsStringAsync();
                        Console.WriteLine("Response: " + data);
                        return data;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return string.Empty;
                }
            }
        }

        // Method to create new lecture
        public static async Task<string> PostLecture(string facultyName, string degreeProgram, string academicYear, string subjectCode, string lecturersID, string lectureHall, string lectureDay, string lectureStart, string lectureEnd)
        {
            var inputData = new
            {
                academic_year = academicYear,
                day = lectureDay,
                degree = degreeProgram,
                faculty = facultyName,
                lecture_hall = lectureHall,
                subject_code = subjectCode,
                teacher_id = lecturersID,
                time_slot = new
                {
                    end_time = lectureEnd,
                    start_time = lectureStart
                }

            };
            var json = JsonConvert.SerializeObject(inputData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string postURL = $"{baseURL}/lecture/create"; // Correct URL for adding a new student

                    using (HttpResponseMessage res = await client.PostAsync(postURL, content))
                    {
                        res.EnsureSuccessStatusCode(); // Throw if not a success code.
                        string data = await res.Content.ReadAsStringAsync();
                        Console.WriteLine("Response: " + data);
                        return data;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return string.Empty;
                }
            }
        }


    }
}
