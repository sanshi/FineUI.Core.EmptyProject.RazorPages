using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FineUI.Core.EmptyProject.RazorPages.Pages
{
    public class HelloModel : BaseModel
    {
        public void OnGet()
        {
            
        }

        public IActionResult OnPostBtnHello_Click()
        {
            Alert.Show("你好 FineUI！", MessageBoxIcon.Warning);

            return UIHelper.Result();
        }


    }
}