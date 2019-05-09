using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfNotesApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string Login(string email, string pass);

        [OperationContract]
        int Register(string email, string pass, string name);

        [OperationContract]
        int AddNote(string title, string details, string name);

        [OperationContract]
        List<Notes> getNotes(string name);

        [OperationContract]
        int UpdateNote(string title,string details,int id);

        [OperationContract]
        Notes getNote(int id);

        [OperationContract]
        int deleteNote(int id);
        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "WcfNotesApp.ContractType".
    [DataContract]
    public class Users
    {
        int id1;
        string name;
        string password;
        string email;
        [DataMember]
        public int id
        {
            set
            {
                id1=value;
            }
            get
            {
                return id1;
            }
        }
        [DataMember]
        public string Name
        {
            set
            {
                name=value;
            }
            get
            {
                return name;
            }
        }
        [DataMember]
        public string Password
        {
            set
            {
                password=value;
            }
            get
            {
                return password;
            }
        }
        [DataMember]
        public string Email
        {
            set
            {
                email=value;
            }
            get
            {
                return email;
            }
        }
    }

    [DataContract]
    public class Notes
    {
        int id1;
        string title;
        string details;
        string name;
        [DataMember]
        public int Id
        {
            set
            {
                id1 = value;
            }
            get
            {
                return id1;
            }
        }
        [DataMember]
        public string Title
        {
            set
            {
                title=value;
            }
            get
            {
                return title;
            }
        }
        [DataMember]
        public string Details
        {
            set
            {
                details=value;
            }
            get
            {
                return details;
            }
        }
        [DataMember]
        public string Name
        {
            set
            {
                name=value;
            }
            get
            {
                return name;
            }
        }
    }
}
