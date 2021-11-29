using JaiBalayya;
public interface IEmployeeOperations
{
    void Add(Employee e);
    void Delete(int id);
    Employee Find(int id);
    void Display();
}
