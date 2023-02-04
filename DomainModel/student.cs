namespace DomainModel;
public class student
{
    private string username;
    private string password;
    private string name;
    private string email;
    private enum role { student, teacher, admin };
    private int id;

    
    private bool login(string username, string password)
    {
        //check if username and password are correct//
        return true;
    }
    
    private void logout()
    {
        //logout//
    }
    
    private bool register(string username, string password, string name, string email)
    {
        //check if username is already taken//
        //check if email is already taken//
        //if not, register//
        return true;
    }
    
    private bool changePassword(string username, string password, string newPassword)
    {
        //check if username and password are correct//
        //if so, change password//
        return true;
    }
    //method to edit profile//
    private bool editProfile(string username, string password, string name, string email)
    {
        //check if username and password are correct//
        //if so, edit profile//
        return true;
    }
    
    public bool viewProfile(string username, string password)
    {
        //check if username and password are correct//
        //if so, view profile//
        return true;
    }
    
    public bool viewCalendar(string username, string password)
    {
        //check if username and password are correct//
        //if so, view calendar//
        calendar calendar = new calendar();
        calendar.viewCalendar(username, password);
        return true;
    }
    
    public bool viewAssignments(string username, string password)
    {
        //check if username and password are correct//
        //if so, view assignments//
        assignment assignment = new assignment();
        return true;
    }
    public 

    
    public bool viewMessages(string username, string password)
    {
        //check if username and password are correct//
        //if so, view messages//
        inbox inbox = new inbox();
        inbox.viewMessages(username, password);

        return true;
    }
    
    public bool viewCourses(string username, string password)
    {
        //check if username and password are correct//
        //if so, view courses//
        course course = new course();
        return true;
    }
    public bool viewDiscussion(string username, string password)
    {
        //check if username and password are correct//
        //if so, view discussion//
        discussion discussion = new discussion();
        return true;
    }

    public bool viewStudentDetails(string username)
    {
        //check if username exists//
        //if so, view student details//
        return true;
    }
}
