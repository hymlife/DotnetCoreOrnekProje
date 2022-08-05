using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace StudentApplication.Web.Helper
{

    public class StudentAPI
    {
        private string _apiBaseURI = "http://localhost Jump :60883";
        public HttpClient InitializeClient()
        {
            var client = new HttpClient();
            //Passing service base url 
            client.BaseAddress = new Uri(_apiBaseURI);

            client.DefaultRequestHeaders.Clear();
            //Define request data format 
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return client;

        }
    }

    public class StudentDTO
    {
        public long StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime? DateOfRegistration { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }
}