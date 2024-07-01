using StudentsManagementSystemForm;

namespace forms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new UpdateStudent());
            Application.Run(new AddNewStudent());
            //Application.Run(new AddNewSubject());
            //Application.Run(new AddNewTeacher());
            //Application.Run(new CreateNewLecture());
            //Application.Run(new AddFaculty());
            //Application.Run(new AddNewTeacher());
            //Application.Run(new CreateNewLecture());
            //Application.Run(new UpdateStudent());
            //Application.Run(new UpdateSubject());
            //Application.Run(new UpdateTeacher());
            //Application.Run(new UpdateFaculty());
        }
    }
}