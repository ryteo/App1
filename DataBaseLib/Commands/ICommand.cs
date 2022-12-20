using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataBaseLib.Commands
{
    internal interface ITableEditorCommand
    {
        public void Select(string[] args);
        public void insertmain(string[] args);
        public void insertteachers(string[] args);
        public void insertpost(string[] args);
        public void insertsubjects(string[] args);
        public void deletemain(string[] args);
        public void deleteteachers(string[] args);
        public void deletepost(string[] args);
        public void deletesubjects(string[] args);
        public void Updatemain(string[] args);
        public void Updateteachers(string[] args);
        public void Updatepost(string[] args);
        public void Updatesubjects(string[] args);

    }
}
