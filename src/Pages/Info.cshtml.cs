using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoApp.Pages
{
    public class InfoModel : PageModel
    {
        public string Name { get; set; }
        public string HostName { get; set; }
        public void OnGet()
        {
            Name = System.Environment.MachineName;
            HostName = System.Net.Dns.GetHostName(); 
        }
    }
}
