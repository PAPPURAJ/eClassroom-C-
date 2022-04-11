using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eClassroom
{
    class MyFirebaseDatabase
    {
        IFirebaseClient client;
        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "q8wgnL6pPC7RAJZ1LEcnBUIrRVbcoWEWWAAusYvO",
            BasePath = "https://online-class-reminder-e4bf0.firebaseio.com/"
        };

        public MyFirebaseDatabase()
        {

            try
            {
                client = new FireSharp.FirebaseClient(fcon);
            }
            catch
            {
             
            }
        }


        public void addUser(UserData userDt)
        {
            int Counter;
            try
            {
                Counter = int.Parse(client.Get(@"Users/Counter").ResultAs<string>());

            }
            catch
            {
                Counter = 0;
            }



            var set2 = client.Set(@"Users/Counter", ++Counter);
            var set3 = client.Set(@"Users/Data/" + Counter, userDt);

        }


        public int checkUserisAdmin(string email,string pass)
        {
            int Counter;
            try
            {
                Counter = int.Parse(client.Get(@"Users/Counter").ResultAs<string>());
            }
            
            catch{
                Counter=0;
            }

            for (int i = 1; i <= Counter; i++)
            {
                FirebaseResponse reso = client.Get(@"Users/Data/" + i);
                UserData userData = reso.ResultAs<UserData>();
                Console.Write(userData.name);
                if (userData.email.Equals(email) && userData.pass.Equals(pass))
                {
                    if (userData.userType.Equals("admin")){
                        new MainMenu(true, userData.name, (userData.classID + userData.classPass).Replace("@", "__").Replace(".", "_"),userData.email).Show();
                        return 1;
                    }
                    else{
                        new ConnectClass(userData.name,userData.email).Show(); 
                        return 0;
                    }
                      
                       
                }
            }

            return -1;

        }


        public bool updateUserPass(string email, string newPass)
        {


            int Counter;
            try
            {
                Counter = int.Parse(client.Get(@"Users/Counter").ResultAs<string>());
            }

            catch
            {
                Counter = 0;
            }

            for (int i = 1; i <= Counter; i++)
            {
                FirebaseResponse reso = client.Get(@"Users/Data/" + i);
                UserData userData = reso.ResultAs<UserData>();
                Console.Write(userData.name);
                if (userData.email.Equals(email))
                {

                    UserData std = new UserData()
                    {
                        classID=userData.classID,
                        classPass=userData.classPass,
                        email=userData.email,
                        name=userData.name,
                        pass=newPass,
                        userType=userData.userType

                    };
                    var setter = client.Update("Users/Data/" + i, std);
                    return true;


                }
            }return false;
           

        }


        public bool editOrDeleteNotice(string dbLink,string delete)
        {
            int Counter;
            try
            {
                Counter = int.Parse(client.Get(@""+dbLink+"Notice/Counter").ResultAs<string>());
            }

            catch
            {
                Counter = 0;
            }

            for (int i = 1; i <= Counter; i++)
            {
                FirebaseResponse reso = client.Get(@"" + dbLink + "Notice/Data/" + i);
                NoticeData userData = reso.ResultAs<NoticeData>();
                Console.Write(userData.message);
                if (userData.message.Equals(delete))
                {

                    client.Delete(@"" + dbLink + "Notice/Data/" + i);
                    return true; 


                }
            } return false;
           


        }



        public bool deleteRoutine(string dbLink, string clssTime)
        {
            int Counter;
            try
            {
                Counter = int.Parse(client.Get(@"" + dbLink + "Routine/Counter").ResultAs<string>());
            }

            catch
            {
                Counter = 0;
            }

            for (int i = 1; i <= Counter; i++)
            {
                FirebaseResponse reso = client.Get(@"" + dbLink + "Routine/Data/" + i);
                RoutineData userData = reso.ResultAs<RoutineData>();
                Console.Write(userData.RoutineName);
                if (userData.RoutineDuration.Equals(clssTime))
                {
                         client.Delete(@"" + dbLink + "Routine/Data/" + i);
                         return true;

                }
            } return false;



        }



        public bool updateUserPass(string email,string oldPass, string newPass)
        {


            int Counter;
            try
            {
                Counter = int.Parse(client.Get(@"Users/Counter").ResultAs<string>());
            }

            catch
            {
                Counter = 0;
            }

            for (int i = 1; i <= Counter; i++)
            {
                FirebaseResponse reso = client.Get(@"Users/Data/" + i);
                UserData userData = reso.ResultAs<UserData>();
                Console.Write(userData.name);
                if (userData.email.Equals(email) && userData.pass.Equals(oldPass))
                {

                    UserData std = new UserData()
                    {
                        classID = userData.classID,
                        classPass = userData.classPass,
                        email = userData.email,
                        name = userData.name,
                        pass = newPass,
                        userType = userData.userType

                    };
                    var setter = client.Update("Users/Data/" + i, std);
                    return true;


                }
            } return false;


        }


    }
}
