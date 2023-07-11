using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using TestCompany.Data;
using TestCompany.Models;

namespace TestCompany.Rules
{
	public partial class NamesBusinessRules : TestCompany.Data.BusinessRules
    {
        
        /// <summary>
        /// Rule "PreventDuplicateNames" implementation:
        /// This method will execute in any view before an action
        /// with a command name that matches "Insert".
        /// </summary>
        [Rule("r100")]
        public void r100Implementation(NamesModel instance)
        {
           using (SqlText checkForDuplicate = new SqlText("SELECT COUNT(*) FROM [dbo].[Names] WHERE Names = @Name"))
            {
                checkForDuplicate.AddParameter("@Name", instance.Names_);
                int count = Convert.ToInt32(checkForDuplicate.ExecuteScalar());
                if (count > 0)
                {
                    PreventDefault(); // prevent the insert from happening
                    Result.ShowMessage("Duplicate names are not allowed."); // show an error message to the user
                }
            }
        }
    }
}
