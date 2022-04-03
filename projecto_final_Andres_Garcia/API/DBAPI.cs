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


        /// <summary>
        /// It creates a user in the database.
        /// </summary>
        /// <param name="User">The user object that contains the username, password, and isAdmin
        /// boolean.</param>
        /// <returns>
        /// The method returns a boolean value.
        /// </returns>
        public Boolean CreateUser(User obj)
        {
            bool userCreated = false;
            // pass json object to API with username, password and bool 
            // true to create an admin user false to create a regular user.
            string json = JsonConvert.SerializeObject(obj);

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


        /// <summary>
        /// It updates a user in the database.
        /// </summary>
        /// <param name="User">The user object that will be passed to the API.</param>
        /// <param name="id">The id of the product to be updated.</param>
        /// <returns>
        /// The method returns a boolean value.
        /// </returns>
        public Boolean UpdateUser(User obj, string id)
        {
            bool userUpdated = false;
            // pass json object to API with product details.
            string json = JsonConvert.SerializeObject(obj);

            try
            {
                var request = new RestRequest("updateuser/" + id, Method.PUT)
                    .AddJsonBody(json);
                var response = this.client.Execute(request);

                if (JsonConvert.DeserializeObject<DataParsing>(response.Content).msg == "The user has being successfully updated.")
                {
                    userUpdated = true;
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex);
            }

            return userUpdated;
        }

        /// <summary>
        /// It deletes a user from the database.
        /// </summary>
        /// <param name="id">The id of the user you want to delete.</param>
        /// <returns>
        /// The method returns a boolean value.
        /// </returns>
        public Boolean DeleteUser(string id)
        {
            bool userDeleted = false;
            // pass json object to API with product id to delete.
            try
            {
                var request = new RestRequest("deleteuser/" + id, Method.DELETE);
                var response = this.client.Execute(request);

                if (JsonConvert.DeserializeObject<DataParsing>(response.Content).msg == "The user has being successfully deleted.")
                {
                    userDeleted = true;
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex);
            }

            return userDeleted;
        }

        /// <summary>
        /// It returns a list of users.
        /// </summary>
        /// <returns>
        /// A list of User objects.
        /// </returns>
        public List<User> GetUsers()
        {
            List<User> userList = new List<User>();
            try
            {
                var request = new RestRequest("getusers", Method.GET);
                var response = this.client.Execute(request);
                var data = JsonConvert.DeserializeObject<DataParsing>(response.Content);

                foreach (var item in data.results)
                {
                    string username = item.username;
                    string name = item.name;
                    bool isAdmin = item.is_admin;

                    User objUser = new User(username,name,"********",isAdmin);
                    userList.Add(objUser);
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex);
            }
            return userList;
        }

        /// <summary>
        /// It takes in a User object and returns a Tuple of two booleans. The first boolean is true if
        /// the user has access and the second boolean is true if the user is an admin.
        /// </summary>
        /// <param name="User">The user object that contains the username and password.</param>
        /// <returns>
        /// The Tuple<bool,bool> is being returned. The first bool is the access granted and the second
        /// bool is the isAdmin.
        /// </returns>
        public Tuple<bool, bool> UserLogIn(User obj)
        {
            bool accessGranted = false;
            bool isAdmin = false;

            // pass json object to API with username and password to 
            // validate if access should be granted.
            string json = JsonConvert.SerializeObject(obj);

            try
            {
                var request = new RestRequest("userlogin", Method.POST)
                    .AddJsonBody(json);
                var response = this.client.Execute(request);

                if (JsonConvert.DeserializeObject<DataParsing>(response.Content).access == "Granted")
                {
                    accessGranted = true;
                }
                if (JsonConvert.DeserializeObject<DataParsing>(response.Content).is_admin)
                {
                    isAdmin = true;
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex);
            }
            return Tuple.Create(accessGranted, isAdmin);
        }

        /// <summary>
        /// It creates a product in the database.
        /// </summary>
        /// <param name="Product">The product object that will be passed to the API.</param>
        /// <returns>
        /// The method returns a boolean value.
        /// </returns>
        public Boolean CreateProduct(Product obj)
        {
            bool producCreated = false;
            // pass json object to API with product details.
            string json = JsonConvert.SerializeObject(obj);
            Console.WriteLine(json);

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

        /// <summary>
        /// It updates a product in the database.
        /// </summary>
        /// <param name="Product">The product object that will be passed to the API.</param>
        /// <param name="id">The id of the product to be updated.</param>
        /// <returns>
        /// The method returns a boolean value.
        /// </returns>
        public Boolean UpdateProduct(Product obj, int id)
        {
            bool producUpdated = false;
            // pass json object to API with product details.
            string json = JsonConvert.SerializeObject(obj);

            try
            {
                var request = new RestRequest("updateproduct/" + id, Method.PUT)
                    .AddJsonBody(json);
                var response = this.client.Execute(request);

                if (JsonConvert.DeserializeObject<DataParsing>(response.Content).msg == "The product has being successfully updated.")
                {
                    producUpdated = true;
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex);
            }

            return producUpdated;
        }

        /// <summary>
        /// It deletes a product from the database.
        /// </summary>
        /// <param name="id">The id of the product you want to delete.</param>
        /// <returns>
        /// The method returns a boolean value.
        /// </returns>
        public Boolean DeleteProduct(int id)
        {
            bool producDeleted = false;
            // pass json object to API with product id to delete.
            try
            {
                var request = new RestRequest("deleteproduct/" + id, Method.DELETE);
                var response = this.client.Execute(request);

                if (JsonConvert.DeserializeObject<DataParsing>(response.Content).msg == "The product has being successfully deleted.")
                {
                    producDeleted = true;
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex);
            }

            return producDeleted;
        }

        /// <summary>
        /// It returns a list of products.
        /// </summary>
        /// <returns>
        /// A list of Product objects.
        /// </returns>
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

        /// <summary>
        /// It creates a category in the database.
        /// </summary>
        /// <param name="Category">The category object that will be passed to the API.</param>
        /// <returns>
        /// The method returns a boolean value.
        /// </returns>
        public Boolean CreateCategory(Category obj)
        {
            bool categoryCreated = false;
            // pass json object to API with category details
            string json = JsonConvert.SerializeObject(obj);

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

        /// <summary>
        /// It returns a list of products.
        /// </summary>
        /// <returns>
        /// A list of Product objects.
        /// </returns>
        public List<Inventory> GetProductsCategories()
        {
            List<Inventory> productList = new List<Inventory>();
            try
            {
                var request = new RestRequest("getproductscategories", Method.GET);
                var response = this.client.Execute(request);
                var data = JsonConvert.DeserializeObject<DataParsing>(response.Content);

                foreach (var item in data.results)
                {
                    int prodCode = item.prod_code;
                    int catCode = item.cat_code;
                    string prodDescription = item.prod_desc; 
                    string catDescription = item.cat_desc;

                    Inventory objProduct = new Inventory(prodCode, catCode, prodDescription, catDescription);
                    productList.Add(objProduct);
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex);
            }
            return productList;
        }

        /// <summary>
        /// It updates a category in the database.
        /// </summary>
        /// <param name="Category">The category object that will be updated.</param>
        /// <param name="id">The id of the category to be updated.</param>
        /// <returns>
        /// The method returns a boolean value.
        /// </returns>
        public Boolean UpdateCategory(Category obj, int id)
        {
            bool categoryUpdated = false;
            // pass json object to API with category details
            string json = JsonConvert.SerializeObject(obj);

            try
            {
                var request = new RestRequest("updatecategory/" + id, Method.PUT)
                    .AddJsonBody(json);
                var response = this.client.Execute(request);

                if (JsonConvert.DeserializeObject<DataParsing>(response.Content).msg == "The category has being successfully updated.")
                {
                    categoryUpdated = true;
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex);
            }

            return categoryUpdated;
        }

        /// <summary>
        /// Delete a category from the database
        /// </summary>
        /// <param name="id">The id of the category to be deleted.</param>
        /// <returns>
        /// The method returns a boolean value.
        /// </returns>
        public Boolean DeleteCategory(int id)
        {
            bool categoryDeleted = false;
            try
            {
                var request = new RestRequest("deletecategory/" + id, Method.DELETE);
                var response = this.client.Execute(request);

                if (JsonConvert.DeserializeObject<DataParsing>(response.Content).msg == "The category has being successfully deleted.")
                {
                    categoryDeleted = true;
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex);
            }

            return categoryDeleted;
        }

        /// <summary>
        /// It returns a list of categories.
        /// </summary>
        /// <returns>
        /// A list of Category objects.
        /// </returns>
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
