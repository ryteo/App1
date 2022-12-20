using DataBaseLib.Access;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLib.Commands
{
    internal class Table1Commands : ITableEditorCommand
    {
        // ЕСЛИ нужна другая БД, просто меняем AccessDataBaseController
        // на нужную, например SQLiteDataBaseController
        // в следующей строке
        private AccessDataBaseController controller = new AccessDataBaseController();

        public void Select(string[] args)
        {

        }
        public void insertmain(string[] args)
        {
            string main = $"INSERT INTO [main] " + $"([Код-main], [Код-teachers], [Код-post], [Код-subjects], [Текст]) " + $"VALUES ('{args[0]}', '{args[1]}', '{args[2]}', '{args[3]}' , '{args[4]}')";
            controller.ExecuteCommand(main);
        }
        public void insertpost(string[] args)
        {
            string post = $"INSERT INTO [post] " + $"([Код-post], [Текст]) " + $"VALUES ('{args[2]}', '{args[4]}')";
            controller.ExecuteCommand(post);
        }
        public void insertsubjects(string[] args)
        {
            string subjects = $"INSERT INTO [subjects] " + $"([Код-sub], [Текст]) " + $"VALUES ('{args[3]}', '{args[4]}')";
            controller.ExecuteCommand(subjects);
        }
        public void insertteachers(string[] args)
        {
            string teachers = $"INSERT INTO [teachers] " + $"([Код-teach], [Текст]) " + $"VALUES ('{args[1]}', '{args[4]}')";
            controller.ExecuteCommand(teachers);
        }
       

        public void Updatemain(string[] args)
        {
            string main = $"UPDATE [main] SET [Код-main] = '{args[0]}' " +
                $"[Код-post] = {args[2]} " +
                $"[Код-subjects] = {args[3]} " +
                $"[Код-teachers] = {args[1]} ";
                
            controller.ExecuteCommand(main);
        }
        public void Updatepost(string[] args)
        {
            string post = $"UPDATE [post] SET [Код-post] = '{args[2]}' " +
                $"WHERE [Текст] = {args[4]} ";
            controller.ExecuteCommand(post);
        }
        public void Updatesubjects(string[] args)
        {
            string subjects = $"UPDATE [subjects] SET [Код-sub] = {args[3]} " +
                $"WHERE [Текст] = {args[4]}";
            controller.ExecuteCommand(subjects);
        }
        public void Updateteachers(string[] args)
        {
            string teachers = $"UPDATE [teachers] SET [Код-teach] = {args[1]} " +
                $"WHERE [Текст] = {args[4]}";
            controller.ExecuteCommand(teachers);
        }
        public void deletemain(string[] args)
        {
            string main = $"DELETE FROM [main] " + $"WHERE [Код-main] = {args[0]}";
            controller.ExecuteCommand(main);
        }
        public void deletepost(string[] args)
        {
            string post = $"DELETE FROM [post] " + $"WHERE [Код-post] = {args[2]}";
            controller.ExecuteCommand(post);
        }
        public void deletesubjects(string[] args)
        {
            string subjects = $"DELETE FROM [subjects] " + $"WHERE [Код-sub] = {args[3]}";
            controller.ExecuteCommand(subjects);
        }

        public void deleteteachers(string[] args)
        {
            string teachers = $"DELETE FROM [teachers] " + $"WHERE [Код-teach] = {args[1]}";
            controller.ExecuteCommand(teachers);
        }


    }
}
