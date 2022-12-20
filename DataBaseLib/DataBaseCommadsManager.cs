using DataBaseLib.Access;
using DataBaseLib.Commands;
using System.Data;

namespace DataBaseLib;

/// <summary>
/// Выполнение команд пользователя
/// </summary>
public class DataBaseCommadsManager
{


    public DataTable GetDataTable(string tableName)
    {
        BaseCommands command = new BaseCommands();        
        return command.GetDataTable(tableName);
    }

    ITableEditorCommand command;
    public void insertmain(string[] args, string tableName)
    {
        switch (tableName)
        {
            case "main":
                command = new Table1Commands();
                break;
        }
        command.insertmain(args);
    }
    public void insertteachers(string[] args, string tableName)
    {
        switch (tableName)
        {
            case "teachers":
                command = new Table1Commands();
                break;
        }
        command.insertteachers(args);
    }
    public void insertsubjects(string[] args, string tableName)
    {
        switch (tableName)
        {
            case "subjects":
                command = new Table1Commands();
                break;
        }
        command.insertsubjects(args);
    }
    public void insertpost(string[] args, string tableName)
    {
        switch (tableName)
        {
            case "post":
                command = new Table1Commands();
                break;
        }
        command.insertpost(args);
    }
    public void deletemain(string[] args, string tableName)
    {
        switch (tableName)
        {
            case "main":
                command = new Table1Commands();
                break;
        }
        command.deletemain(args);
    }
    public void deleteteachers(string[] args, string tableName)
    {
        switch (tableName)
        {
            case "teachers":
                command = new Table1Commands();
                break;
        }
        command.deleteteachers(args);
    }
    public void deletesubjects(string[] args, string tableName)
    {
        switch (tableName)
        {
            case "subjects":
                command = new Table1Commands();
                break;
        }
        command.deletesubjects(args);
    }
    public void deletepost(string[] args, string tableName)
    {
        switch (tableName)
        {
            case "post":
                command = new Table1Commands();
                break;
        }
        command.deletepost(args);
    }
    public void Updatemain(string[] args, string tableName)
    {

        switch (tableName)
        {
            case "main":
                command = new Table1Commands();
                break; 
        }
        command.Updatemain(args);
    }
    public void Updatepost(string[] args, string tableName)
    {

        switch (tableName) { 
                case "post":
            command = new Table1Commands();
            break; 
        }
        command.Updatepost(args);
    }
    public void Updatesubjects(string[] args, string tableName)
    {

        switch (tableName) { 
            case "subjects":
            command = new Table1Commands();
            break; 
        }
        command.Updatesubjects(args);
    }
    public void Updateteachers(string[] args, string tableName)
    {

        switch (tableName)
        {
            case "teachers":
                command = new Table1Commands();
                break; 
        }
        command.Updateteachers(args);
    }
            
}
        
    
    


