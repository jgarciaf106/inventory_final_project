using Newtonsoft.Json;
using projecto_final_Andres_Garcia.Classes;
using RestSharp;
using RestSharp.Serialization.Json;
using System;
using System.IO;
using System.Net;
using System.Linq;
using projecto_final_Andres_Garcia.Data;
using System.Collections.Generic;
using System.Data;

namespace projecto_final_Andres_Garcia.API
{
    internal class DBAPI
    {
        RestClient client = new RestClient("https://ag-uca.herokuapp.com/api/");


        public Boolean CreateUser(User obj)
        {
            bool userCreated = false;
            // pass json object to API with username, password and bool 
            // true to create an admin user false to create a regular user.
            string json = $"{{\"username\":\"{obj.username}\",\"name\":\"{obj.name}\",\"password\":\"{obj.password}\",\"isadmin\":\"{obj.isAdmin}\"}}";

            try
            {
                var request = new RestRequest("createuser", Method.POST)
                    .AddJsonBody(json);
                var response = this.client.Execute(request);

                if (JsonConvert.DeserializeObject<DataParsing>(response.Content).msg == "User account was successfully created.")
                {
                    userCreated = true;
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex);
            }

            return userCreated;
        }

        public Boolean UserLogIn(User obj)
        {
            bool accessGranted = false;

            // pass json object to API with username and password to 
            // validate if access should be granted.
            string json = $"{{\"username\":\"{obj.username}\",\"password\":\"{obj.password}\"}}";

            try
            {
                var request = new RestRequest("userlogin", Method.POST)
                    .AddJsonBody(json);
                var response = this.client.Execute(request);

                if (JsonConvert.DeserializeObject<DataParsing>(response.Content).access == "Granted")
                {
                    Console.WriteLine(JsonConvert.DeserializeObject<DataParsing>(response.Content).is_admin);
                    accessGranted = true;
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex);
            }
            return accessGranted;
        }

        public Boolean CreateProduct(Product obj)
        {
            bool producCreated = false;
            // pass json object to API with product details.
            string json = $"{{\"prodcode\":\"{obj.prodcode}\",\"productcatcode\":\"{obj.catcode}\",\"description\":\"{obj.description}\"}}";

            try
            {
                var request = new RestRequest("createproduct", Method.POST)
                    .AddJsonBody(json);
                var response = this.client.Execute(request);

                if (JsonConvert.DeserializeObject<DataParsing>(response.Content).msg == "The product has being successfully created.")
                {
                    producCreated = true;
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex);
            }

            return producCreated;
        }

        public List<Product> GetProducts()
        {
            List<Product> productList = new List<Product>();
            try
            {
                var request = new RestRequest("getproducts", Method.GET);
                var response = this.client.Execute(request);
                var data = JsonConvert.DeserializeObject<DataParsing>(response.Content);

                foreach (var item in data.results)
                {
                    int prodCode = item.prod_code;
                    int catCode = item.cat_code;
                    string description = item.description;

                    Product objProduct = new Product(prodCode, catCode, description);
                    productList.Add(objProduct);
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex);
            }
            return productList;
        }
        
        public Boolean Createcategory(Category obj)
        {
            bool categoryCreated = false;
            // pass json object to API with category details
            string json = $"{{\"catcode\":\"{obj.catcode}\",\"description\":\"{obj.description}\"}}";

            try
            {
                var request = new RestRequest("createcategory", Method.POST)
                    .AddJsonBody(json);
                var response = this.client.Execute(request);

                if (JsonConvert.DeserializeObject<DataParsing>(response.Content).msg == "The Category has being successfully created.")
                {
                    categoryCreated = true;
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex);
            }

            return categoryCreated;
        }

        public List<Category> GetCategories()
        {
            List<Category> categoryList = new List<Category>();
            try
            {
                var request = new RestRequest("getcategories", Method.GET);
                var response = this.client.Execute(request);
                var data = JsonConvert.DeserializeObject<DataParsing>(response.Content);

                foreach (var item in data.results)
                {
                    int catCode = item.cat_code;
                    string description = item.description;

                    Category objCategory = new Category(catCode, description);
                    categoryList.Add(objCategory);
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex);
            }
            return categoryList;
        }

    }
}
