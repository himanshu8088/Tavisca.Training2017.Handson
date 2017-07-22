/*                                          Problem 2.
  Write a program to display student information. Accept Student’s name, Roll no, Age, class, and university name and display it on console.
*/
namespace Problem2
{
    public interface IRecord
    {
        string GetName();
        void SetName(string name);

        int GetAge();
        void SetAge(int age);

        string GetUniversity();
        void SetUniversity(string university);

    }  


}
