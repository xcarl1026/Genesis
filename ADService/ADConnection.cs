using System;
using System.Collections.Generic;
using System.Text;
using System.DirectoryServices.AccountManagement;
using System.DirectoryServices.ActiveDirectory;

namespace ADService
{
    class ADConnection
    {
       // private PrincipalContext context { get; set; }
        
        public static PrincipalContext GetADConnectionContext(string domain, string username, string password)
        {
            PrincipalContext context = null;
            try
            {
                context = new PrincipalContext(ContextType.Domain, domain, username, password);
            }
            catch (PrincipalException e)
            {
                Console.WriteLine(e.Message);
            }
            return context;
        }
    }
 
}
