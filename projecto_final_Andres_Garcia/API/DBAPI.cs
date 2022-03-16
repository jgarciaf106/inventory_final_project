using Newtonsoft.Json;
using projecto_final_Andres_Garcia.Classes;
using RestSharp;
using RestSharp.Serialization.Json;
using System;
using System.IO;
using System.Net;

namespace projecto_final_Andres_Garcia.API
{
    internal class DBAPI
    {
        private string url = "";

        public DBAPI(string url)
        {
            this.url = url;
        }

        public void CreateUser(User obj)
        {
            string json = $"{{\"username\":\"{obj.username}\",\"name\":\"{obj.name}\",\"password\":\"{obj.password}\"}}";

            try
            {
                var client = new RestClient(this.url);
                var request = new RestRequest("createuser", Method.POST)
                    .AddJsonBody(json);

                var response = client.Execute(request);
                Console.WriteLine(response.Content);

            }
            catch (WebException ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void UserLogIn(User obj)
        {
            string json = $"{{\"username\":\"{obj.username}\",\"password\":\"{obj.password}\"}}";

            try
            {
                var client = new RestClient(this.url);
                var request = new RestRequest("userlogin", Method.POST)
                    .AddJsonBody(json);
                    
                var response = client.Execute(request);
                Console.WriteLine(response.Content);

            }
            catch (WebException ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void CreateProduct(Product obj)
        {
            string json = $"{{\"prodcode\":\"{obj.prodcode}\",\"productcatcode\":\"{obj.catcode}\",\"description\":\"{obj.description}\"}}";

            try
            {
                var client = new RestClient(this.url);
                var request = new RestRequest("createproduct", Method.POST)
                    .AddJsonBody(json);

                var response = client.Execute(request);
                Console.WriteLine(response.Content);

            }
            catch (WebException ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void GetProducts()
        {
            try
            {
                var client = new RestClient(this.url);
                var request = new RestRequest("getproducts", Method.GET);
                var response = client.Execute(request);
                Console.WriteLine(response.Content);

            }
            catch (WebException ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void Createcategory(Category obj)
        {
            string json = $"{{\"catcode\":\"{obj.catcode}\",\"description\":\"{obj.description}\"}}";

            try
            {
                var client = new RestClient(this.url);
                var request = new RestRequest("createcategory", Method.POST)
                    .AddJsonBody(json);

                var response = client.Execute(request);
                Console.WriteLine(response.Content);

            }
            catch (WebException ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void GetCategories()
        {
            try
            {
                var client = new RestClient(this.url);
                var request = new RestRequest("getcategories", Method.GET);
                var response = client.Execute(request);
                Console.WriteLine(response.Content);

            }
            catch (WebException ex)
            {
                Console.WriteLine(ex);
            }
        }

    }
}
